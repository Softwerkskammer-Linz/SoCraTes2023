using ArchUnitNET.Domain;
using ArchUnitNET.Fluent;
using ArchUnitNET.Loader;
using ArchUnitNET.xUnit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace ArchUnitSample.Tests;

public class ArchTests
{
    private static readonly Architecture Architecture =
        new ArchLoader().LoadAssemblies(typeof(Api.IExplicitAssemblyReference).Assembly, (typeof(Core.IExplicitAssemblyReference).Assembly)).Build();

    private readonly IObjectProvider<IType> ApiLayer =
        Types().That().ResideInAssembly(".Api", useRegularExpressions: true).As("API Layer");

    private readonly IObjectProvider<IType> CoreLayer =
        Types().That().ResideInAssembly(".Core", useRegularExpressions: true).As("Core Layer");

    [Fact]
    public void Controllers()
    {
        IArchRule ControllerNaming =
            Classes().That().Are(ApiLayer)
                .And().HaveNameEndingWith("Controller")
                .Should().ResideInNamespace("Controllers", true);

        IArchRule ControllerUsage =
            Classes().That().Are(ApiLayer)
                .And().ResideInNamespace("Controllers", true)
                .Should().HaveNameEndingWith("Controller");

        IArchRule ControllerAssigned =
            Classes().That().Are(ApiLayer)
                .And().AreAssignableTo("Microsoft.AspNetCore.Mvc.ControllerBase", useRegularExpressions: true)
                .Should().ResideInNamespace("Controllers", true)
                .AndShould().HaveNameEndingWith("Controller");

        ControllerNaming.Check(Architecture);
        ControllerUsage.Check(Architecture);
        ControllerAssigned.Check(Architecture);
    }

    [Fact]
    public void ApplicationHasValidator()
    {
        IEnumerable<Class> commandAndQueries =
            Architecture.Classes.Where(@class =>
                @class.Namespace.FullName.Contains(".Core")
                && (@class.Name.EndsWith("Query") || @class.Name.EndsWith("Command")));

        foreach (Class commandOrQuery in commandAndQueries)
        {
            IArchRule QueryShouldHaveValidator = Classes().That()
                .Are(CoreLayer)
                .And().ResideInNamespace(commandOrQuery.Namespace.FullName, useRegularExpressions: true)
                .And().HaveNameEndingWith("Validator")
                .Should().Exist().Because("every command or query should have a validator");

            QueryShouldHaveValidator.Check(Architecture);
        }
    }
}

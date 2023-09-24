# Modern modern C++

Core question from Christian:
With all the new features with every new generation, is there a "common" (idiomatic)
way of writing code with the new(est) construct.

Examples:
* Instead of "hard" cast `(int)value` do a specific cast like `static_cast<int>(value)`
* Instead of "oldscool" function definition `int main() {}` do a `auto main() -> int {}`

## Resources

* https://github.com/AnthonyCalandra/modern-cpp-features
  * very good overview on new features
  * lacking a few things

* https://isocpp.github.io/CppCoreGuidelines/CppCoreGuidelines
  * "They are cool, but it's a lot."
  * They include recommendations.
  * Visual Studio has plugin for checker.
    * https://learn.microsoft.com/en-us/cpp/code-quality/using-the-cpp-core-guidelines-checkers?view=msvc-170
  * Alternative: look for `snyk`
  * Alterantive: clang-tidy

* https://cppquiz.org/
  * A lot to learn from this.
  * Only 164 questions, yet curious to learn.

* https://google.github.io/styleguide/cppguide.html
  * Different to core guidelines
  * "Weird naming convetions"

* https://www.oreilly.com/library/view/effective-modern-c/9781491908419/
  * Good information on C++14

* https://godbolt.org/
  * For trying out things

## Findings

Agreement: We're less concerned about subjective things like naming guidelines or similar styling issues.

For GCC-based compiler: not just use `-Wall` - use `-Wall -Wextra`.
And use `-Werror` for good measure.

Regarding annotations: If there is nothing that "enforces" them, it may lead to
undefined behaviour.
Such enforcing is also necessary for a group-based development. With such
enforced checks, wanted style is better followed by more than one (more motivated) person.
Refer to linters & core guidelines in the resources list above.


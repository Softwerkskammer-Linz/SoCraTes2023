# Review my test code style

Abstract: Test steps are extracted as methods, which reside either as methods on the test class, or even on simulator fixtures of collaborators. Steps are called in a fluent API manner.


Basic code and "template" available here:
http://github.com/dertseha/test-snippets
Look for `Steps.h`, `Steps.java`, or `Steps.cs`.


Comments:
* Hides technical details, supports refactorings due to technical part centralized.
* Hides much, but maybe just new & different.
* Has a bit of overengineered vibe - yet experience with this is lacking.
* Separates What from How -- what in names, how in blocks.
* Supports reasoning about behaviour, discussions with business people.

Name proposal:
"Intention centric testing"
Note: The inspiration for this fluent API came from "Behavioural Driven Testing".


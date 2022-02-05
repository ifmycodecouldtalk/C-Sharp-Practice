using classlib;
using static System.Console;

// calling the instance method and static method, both doing the same thing
Person harry = new() { Name = "Harry" };
Person mary = new() { Name = "Mary" };
Person jill = new() { Name = "Jill" };
// call instance method
Person baby1 = harry * mary;
baby1.Name = "Gary";
// call static method
Person baby2 = Person.Procreate(harry, jill);
WriteLine($"{harry.Name} has {harry.Children.Count} children.");
WriteLine($"{mary.Name} has {mary.Children.Count} children.");
WriteLine($"{jill.Name} has {jill.Children.Count} children.");
WriteLine(
 format: "{0}'s first child is named \"{1}\".",
 arg0: harry.Name,
 arg1: harry.Children[0].Name);

// factorial, demonstration of using a local function
WriteLine($"5! is {Person.Factorial(5)}");

// using a delegate
Person p1 = new();
// create a delegate instance that points to the method
Person.DelegateWithMatchingSignature d = new(p1.MethodIWantToCall);
// call the delegate, which calls the method
int answer2 = d("Frog");
WriteLine($"{answer2}"); // 4


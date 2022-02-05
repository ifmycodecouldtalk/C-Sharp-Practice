// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;
using project_2_0;

Person bob = new("Bob");
bob.Name = "Bob";

// adding to the list of Children
bob.Children.Add(new Person("Alfred"));
bob.Children.Add(new Person("Donna"));

/*
Console.WriteLine(bob.ToString());

Console.WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
 arg0: bob.Name,
 arg1: bob.DateOfBirth);
*/

// Printing: amount of children and what their names are
WriteLine($"{bob.Name} has {bob.Children.Count} children");
foreach (var child in bob.Children)
{
    WriteLine($" {child.Name} ");
}

// Using the constructor and using format
Person chris = new(initialName: "Chris");
WriteLine(format:"{0} was created at {1:hh:mm:ss} on a {1:dddd}",
    arg0: chris.Name,
    arg1: chris.Instantiated);

// Using created Methods
chris.WriteToConsole();
WriteLine(chris.GetOrigin());

// using named tuples
var fruit = bob.GetFruit();
WriteLine($"{fruit.Name}, {fruit.Number} there are.");

// inferring tuple names
var tuple1 = (chris.Name, chris.Instantiated);
WriteLine($"This is {tuple1.Name}'s Tuple");

// deconstructing tuples (types can also be deconstructed in a similar way)
(string Fruit, int Amount) = chris.GetFruit();
// Fruit
// Amount

// this section shows how in, in-out, and out works. y becomes a reference to b, and z is never changed
int a = 10;
int b = 20;
int c = 30;
WriteLine($"Before: a = {a}, b = {b}, c = {c}");
chris.PassingParameters(a, ref b, out c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");
int d = 10;
int e = 20;
WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!");
// simplified C# 7.0 or later syntax for the out parameter, we see that f becomes defined in the parameter
bob.PassingParameters(d, ref e, out int f);
WriteLine($"After: d = {d}, e = {e}, f = {f}");
// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;
using project_2_0;

Person bob = new();
bob.Name = "Bob";
bob.DateOfBirth = new DateTime(1998, 06, 20);

Console.WriteLine(bob.ToString());

Console.WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
 arg0: bob.Name,
 arg1: bob.DateOfBirth);

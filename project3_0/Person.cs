using static System.Console;

namespace classlib
{
    public class Person : object
    {
        // fields
        public string? Name; // ? allows null
        public DateTime DateOfBirth;
        public List<Person> Children = new(); // C# 9 or later
        // methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        // static method to "multiply"
        public static Person Procreate(Person p1, Person p2)
        {
            Person baby = new()
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };
            p1.Children.Add(baby);
            p2.Children.Add(baby);
            return baby;
        }
        // defining the * operator
        public static Person operator *(Person p1, Person p2)
        {
            return Procreate(p1, p2);
        }

        // method with a local function
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException(
                $"{nameof(number)} cannot be less than zero.");
            }
            return localFactorial(number);
            int localFactorial(int localNumber) // local function
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }

        // method i will use a delegate for
        public int MethodIWantToCall(string input)
        {
            return input.Length; // it doesn't matter what the method does
        }
        public delegate int DelegateWithMatchingSignature(string s);

    }
}
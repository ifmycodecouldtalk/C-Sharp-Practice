using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic; // List <T>
using static System.Console;

namespace project_2_0
{
    public class Person
    {
        public String? Name;
        public DateTime Instantiated;
        public List<Person> Children = new();
        public readonly string HomePlanet = "Earth";

        public Person(string initialName)
        {
            Name = initialName;
            Instantiated = DateTime.Now;
        }

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {Instantiated:dddd}.");
        }
        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }


        /* Without Tuples
        public class TextAndNumber
        {
            public string? Text;
            public int Number;
        }

        public class LifeTheUniverseAndEverything
        {
            public TextAndNumber GetTheData()
            {
                return new TextAndNumber
                {
                    Text = "What's the meaning of life?",
                    Number = 42
                };
            }
        }
        */

        // With Tuples, below is a method using tuples
        public (string Name, int Number) GetFruit()
        {
            return (Name: "Apples", Number: 5);
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            z = 99;
            x++;
            y++;
            z++;
        }
    }
}

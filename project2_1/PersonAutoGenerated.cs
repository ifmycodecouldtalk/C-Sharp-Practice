using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace project2_1
{
    public partial class Person
    {
        // a property defined using C# 1 - 5 syntax
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }
        // two properties defined using C# 6+ lambda expression body syntax
        public string Greeting => $"{Name} says 'Hello!'";
        public int Age => System.DateTime.Today.Year - DateOfBirth.Year;

        // getter setter
        public string FavoriteIceCream { get; set; }
        // more complex getter and setter
        private string favoritePrimaryColor;
        public string FavoritePrimaryColor
        {
            get
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException(
                        $"{value} is not a primary color. " +
                        "Choose from: red, green, blue.");
                }
            }
        }
    }
}

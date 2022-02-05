// See https://aka.ms/new-console-template for more information
using project2_1;
using static System.Console;

Person sam = new(name: "Sam");
WriteLine(sam.Origin);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
sam.FavoritePrimaryColor = "Red";
WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");
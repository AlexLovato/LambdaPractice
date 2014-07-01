
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", "Soccer Ball", "Football", "Shoulder Pads", 
                "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles"};

            //declare a variable kayakProducts and set it equal to all products that contain the word "Kayak"
            var KayakProducts = new List<string>().Add( products.where( s => s == "Kayak" ));
            KayakProducts.ForEach(print);
            //print the kayakProducts to the console using a foreach loop.

            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"

            //print the shoeProducts to the console using a foreach loop.

            //declare a variable ballProducts and set it equal to all the products that have ball in the name.

            //print the ballProducts to the console using a foreach loop.
            
            //sort ballProducts alphabetically and print them to the console.

            //add six more items to the products list using .add().

            //print the product with the longest name to the console using the .First() extension.

            //print the product with the shortest name to the console using the .First() extension.

            //print the product with the 4th shortest name to the console using an index (you must convert the results to a list using .ToList()).

            //print the ballProduct with the 2nd longest name to the console using an index(you must convert the results to a list using .ToList()).
            
            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDecending() extension).

            //print out the reversedProducts to the console using a foreach loop.

            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.  
            //You will not use a variable to store your list

            Console.ReadKey();
        }
    }
}

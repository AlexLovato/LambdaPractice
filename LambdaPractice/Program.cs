
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
            
            //print the kayakProducts to the console using a foreach loop.
            var KayakProducts = products.Where(x => x.Contains("Kayak"));
            foreach (string a in KayakProducts)
            {
                Console.WriteLine(a);
            }
            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            var ShoeProducts = products.Where(x => x.Contains("shoe"));

            //print the shoeProducts to the console using a foreach loop.
            foreach (string a in ShoeProducts)
            {
                Console.WriteLine(a);
            }
            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
            var BallProducts = products.Where(x => x.Contains("ball"));
            //print the ballProducts to the console using a foreach loop.
            foreach (string a in BallProducts)
            {
                Console.WriteLine(a);
            }
            //sort ballProducts alphabetically and print them to the console.

            BallProducts.OrderBy(x => x);
            //add six more items to the products list using .add().
           products.Add("baseball");
           products.Add("basketball");
           products.Add("football");
           products.Add("soccer ball");
           products.Add("bouncy ball");
           products.Add("pokeball");
            //print the product with the longest name to the console using the .First() extension.
           Console.WriteLine("longest word " + products.OrderBy(x => x.Length).Last());
            //print the product with the shortest name to the console using the .First() extension.
           Console.WriteLine("shortest word " + products.OrderBy(x => x.Length).First());
            //print the product with the 4th shortest name to the console using an index (you must convert the results to a list using .ToList()).
           Console.WriteLine("4th longest word " + products.OrderByDescending(x => x.Length).Skip(3).Take(1).First());
            //print the ballProduct with the 2nd longest name to the console using an index(you must convert the results to a list using .ToList()).
           Console.WriteLine("2nd longest word " + products.OrderByDescending(x => x.Length).Skip(1).Take(1).First());
            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDecending() extension).
           var reversedProducts = products.OrderByDescending(x => x.Length);
            //print out the reversedProducts to the console using a foreach loop.
           foreach (string a in reversedProducts)
           {
               Console.WriteLine(a);
           }
            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.  
            //You will not use a variable to store your list
           products.OrderByDescending(x => x.Length);
           foreach (string a in products)
           {
               Console.WriteLine(a);
           }
            Console.ReadKey();
        }
    }
}

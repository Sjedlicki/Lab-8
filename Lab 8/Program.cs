using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //People List
            List<string> people = new List<string>()
            { "Steve", "Joe", "Kelly", "Slick", "Brad","Megan","Kent","Rick","James","Sabrina" };
            
            //Hometown List
            List<string> hometown = new List<string>()
            {"Rochester","Krypton","Milkyway","Smallsville","Springfield","Apple","Galaxy","Chicago","Detroit","Maceió" };
            
            //Food List
            List<string> food = new List<string>()
            { "Crab","Chicken","Doritos","Pizza","Steak","Ice Cream","Chocolate","Cookies","Tofu","Salad" };

            bool cont = true;
            while (cont == true)
            {
                Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-10)");
                int counter = 1;
                foreach (string peeps in people)
                {
                    Console.WriteLine(counter + ": " + peeps);
                    counter++;
                }

                int.TryParse(Console.ReadLine(), out int input);
                string peep = people[input - 1];
                string home = hometown[input - 1];
                string fav = food[input - 1];


                Console.WriteLine("Excelent choice, you chose " + people[input - 1]);
                Console.WriteLine("Would you like to know more about " + people[input - 1] + "'s hometown or their favorite food?");
                Console.Write("Enter 'home' or 'food'");

                bool run2 = true;
                while (run2 == true)
                {
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "home")
                    {
                        Console.WriteLine(peep + " is from " + home);
                        run2 = false;
                    }
                    else if (answer == "food")
                    {
                        Console.WriteLine(peep + "'s favorite food is " + fav);
                    }

                    else
                    {
                        Console.WriteLine("Invalid Response, Try Again!");
                        run2 = true;
                    }
                }
                Console.WriteLine("Would you like to know more?");
            }

            //foreach (string peeps in people)
            //{
            //    Console.WriteLine(peeps);
            //}
            //foreach (string home in hometown)
            //{
            //    Console.WriteLine(home);
            //}
            //foreach (string foods in food)
            //{
            //    Console.WriteLine(foods);
            //}



            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

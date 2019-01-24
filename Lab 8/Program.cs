using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        static int input;
        static string peep;
        static string home;
        static string fav;

        static void Main(string[] args)
        {
            //People List
            List<string> people = new List<string>()
            { "Steve", "Joe", "Kelly", "Slick", "Brad","Megan","Kent","Rick","James","Sabrina" };

            //Hometown List
            List<string> hometown = new List<string>()
            {"Rochester","Krypton","Milkyway","Smallsville","Springfield","Appletown","Galaxy","Chicago","Detroit","Maceió" };

            //Food List
            List<string> food = new List<string>()
            { "Crab","Chicken","Doritos","Pizza","Steak","Ice Cream","Chocolate","Cookies","Tofu","Salad" };

            bool cont = true;
            while (cont == true)
            {
                Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about?");
                int counter = 1;
                foreach (string peeps in people)
                {
                    Console.WriteLine(counter + ": " + peeps);
                    counter++;
                }

  
                bool valid = false;
                while (valid == false)
                {
                    try
                    {
                        Console.Write("Enter a number (1-" + people.Count + "): ");
                        int.TryParse(Console.ReadLine(), out int input);

                        //Storing input for easier calling later
                        string peep = people[input - 1];
                        string home = hometown[input - 1];
                        string fav = food[input - 1];

                        Console.WriteLine("Excelent choice, you chose " + peep);
                        Console.WriteLine("Would you like to know more about " + peep + "'s hometown or their favorite food?");
                        

                        bool run2 = true;
                        while (run2 == true)
                        {
                            Console.Write("Enter 'home' or 'food': ");
                            string answer = Console.ReadLine().ToLower();

                            if (answer == "home")
                            {
                                Console.WriteLine(peep + " is from " + home);
                                run2 = false;
                            }
                            else if (answer == "food")
                            {
                                Console.WriteLine(peep + "'s favorite food is " + fav);
                                run2 = false;
                            }

                            else
                            {
                                Console.WriteLine("Invalid Response, Try Again!");
                                run2 = true;
                            }
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine(e.StackTrace);
                        Console.WriteLine("Not valid, Try again");
                        valid = false;
                    }
                    catch (FormatException e1)
                    {
                        Console.WriteLine(e1.StackTrace);
                        Console.WriteLine("Learn to format");
                        valid = false;
                    }
                    catch (Exception e2)
                    {
                        Console.WriteLine(e2.StackTrace);
                        Console.WriteLine("You're not doing it right!");
                        valid = false;
                    }
                    valid = true;
                }
                bool run = true;
                while (run == true)
                {
                    Console.Write("Would you like to know more?\nEnter (yes or no): ");
                    string again = Console.ReadLine().ToLower();
                    if (again != "yes" && again != "no")
                    {
                        Console.WriteLine("I'm sorry I didn't catch that, try again");
                        run = true;
                        cont = false;
                    }
                    else if (again == "no")
                    {
                        Console.WriteLine("Have a great day!");
                        run = false;
                        cont = false;
                    }
                    else
                    {
                        Console.Clear();
                        run = false;
                        cont = true;
                    }

                }
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
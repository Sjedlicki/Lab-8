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
            //People Array
            string[] people = { "Steve", "Joe", "Kelly", "Slick", "Brad", "Megan", "Kent", "Rick", "James", "Sabrina" };

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
                // Adding counter to exit from loop if too many errors
                int retry = 0;
                while (valid != true && retry < 3)
                {
                    try
                    {
                        Console.Write("\nEnter a number (1-" + people.Length + "): ");
                        int input = int.Parse(Console.ReadLine());

                        //Storing input for easier calling later
                        string peep = people[input - 1];
                        string home = hometown[input - 1];
                        string fav = food[input - 1];

                        Console.WriteLine("\nExcelent choice, you chose " + peep);
                        Console.WriteLine("\nWould you like to know more about " + peep + "'s hometown or their favorite food?");
                        retry = 0;
                        bool run2 = true;
                        while (run2 == true && retry < 3)
                        {
                            Console.Write("\nEnter 'home' or 'food': ");
                            string answer = Console.ReadLine().ToLower();

                            if (answer == "home")
                            {
                                Console.WriteLine("\n" + peep + " is from " + home);
                                run2 = false;
                                valid = true;
                            }
                            else if (answer == "food")
                            {
                                Console.WriteLine("\n" + peep + "'s favorite food is " + fav);
                                run2 = false;
                                valid = true;
                            }

                            else
                            {
                                Console.WriteLine("\nInvalid Response, Try Again!");
                                retry++;
                                run2 = true;
                                valid = true;
                            }
                        }
                    }
                    // Catching Exceptions Printing and Looping back to try again
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine(e.StackTrace);
                        Console.WriteLine("\n" + e.Message + "\n");
                        retry++;
                        valid = false;
                    }
                    catch (FormatException e1)
                    {
                        Console.WriteLine(e1.StackTrace);
                        Console.WriteLine("\n" + e1.Message + "\n");
                        retry++;
                        valid = false;
                    }
                    catch (Exception e2)
                    {
                        Console.WriteLine(e2.StackTrace);
                        Console.WriteLine("You're not doing it right!");
                        retry++;
                        valid = false;
                    }
                }
                bool run = true;
                while (run == true)
                {
                    if (retry >= 3)
                    {
                        Console.WriteLine("\nMaximum number of attempts reached");
                    }

                    Console.Write("\nWould you like to know more?\n\nEnter (yes or no): ");
                    string again = Console.ReadLine().ToLower();

                    if (again == "no" || again == "n" || again == "exit")
                    {
                        Console.WriteLine("\nHave a great day!");
                        run = false;
                        cont = false;
                    }
                    else if (again == "yes" || again == "y")
                    {
                        Console.Clear();
                        run = false;
                        cont = true;
                    }
                    else if (again != "yes" && again != "no")
                    {
                        Console.WriteLine("\nI'm sorry I didn't catch that, try again");
                        run = true;
                        cont = false;
                    }
                }
            }
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
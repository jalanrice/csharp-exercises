using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5StudioRestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
                      
            
        }

        static void MainMenu()
        {
            int choice = 0;
            List<int> validChoice = new List<int>() { 1, 2 };


            Console.Write("1 See Menu \n2 Access Admin \nEnter number of option: ");
            choice = int.Parse(Console.ReadLine());
            do
            {
                if (validChoice.Contains(choice))
                {
                    break;
                }
                else
                {
                    Console.Write("Please enter a valid choice: ");
                    choice = int.Parse(Console.ReadLine());
                }
            } while (!validChoice.Contains(choice));
            //return choice;

            if (choice == 1)
            {
                Console.Write(MenuMaker());
                Console.ReadLine();
            }
            else if (choice == 2)
            {
                AdminPanel();

            }
        }


        static string MenuMaker()
        {
            return "MenuMaker goes here"; // todo make menu maker
        }

        static void AdminPanel()
        {
            if (PasswordMatches())
            {
                Console.Write("You're in!"); // todo goes to AddItem()
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect. Enter 1 to try again or press RETURN to return to main menu.");
                if (Console.ReadLine() == "1")
                {
                    AdminPanel();
                }
                else
                {
                    MainMenu();
                }

            }
        }

        static string AddItem()
        {
            return null;
        }

        static bool PasswordMatches()
        {
            string password = "1234";
            string passwordAttempt = "";
            Console.Write("Please enter Admin password: ");
            passwordAttempt = Console.ReadLine();

            if (passwordAttempt == password)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }           


    }

    class MenuItem
    {
        private string name;
        private double price;
        private string description;
        private string category;
        private DateTime added;

        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Added { get; set; }


    }

    class Menu
    {
        private string name;
        private List<Object> items;
        private DateTime mostRecent;

        public string Name { get; set; }
        public List<Object> Items { get; set; }
        public DateTime MostRecent { get; set; }
    }
}

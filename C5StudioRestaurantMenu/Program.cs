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

        public static List<MenuItem> menuObjects = new List<MenuItem>();


        static void MainMenu()
        {
            int choice = 0;
            List<int> validChoice = new List<int>() { 1, 2 };


            Console.Write("\n\nMAIN MENU \n\n1 See Menu \n2 Access Admin \nEnter number of option: ");
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
                MenuMaker();
            }
            else if (choice == 2)
            {
                AdminPanel();

            }
        }


        static void MenuMaker()
        {
            StringBuilder appetizer = new StringBuilder();
            StringBuilder breakfast = new StringBuilder();
            StringBuilder lunch = new StringBuilder();
            StringBuilder dinner = new StringBuilder();
            StringBuilder dessert = new StringBuilder();
            StringBuilder newest = new StringBuilder();
        
            StringBuilder fullMenu = new StringBuilder();

            MenuItem newestItem = new MenuItem("", 0, "", "");
            foreach (MenuItem item in menuObjects)
            {
                if (item.Added <= newestItem.Added)
                {
                    newestItem = item;
                }
                

            }

            foreach (MenuItem item in menuObjects)
            {
                if (item.Category == "appetizer")
                    appetizer.Append("***\n" + item.ToString() + "\n***\n");
                if (item.Category == "breakfast")
                    breakfast.Append("***\n" + item.ToString() + "\n***\n");
                if (item.Category == "lunch")
                    lunch.Append("***\n" + item.ToString() + "\n***\n");
                if (item.Category == "dinner")
                    dinner.Append("***\n" + item.ToString() + "\n***\n");
                if (item.Category == "dessert")
                    dessert.Append("***\n" + item.ToString() + "\n***\n");
              
            }

            newest.Append("***\n" + newestItem.ToString() + "\n***");

            Console.WriteLine("\nBREAKFAST\n" + breakfast + "\n\n\nLUNCH\n" + lunch +
                "\n\n\nAPPETIZERS" + appetizer + "\n\n\nDINNER\n" + dinner + "\n\n\nDESSERT\n"
                + dessert + "\n\n\nNEWEST ITEM!! EXCITING!!\n" + newest);
            Console.ReadLine();
            MainMenu();



        }

        static void AdminPanel()
        {
            if (PasswordMatches())
            {
                AddItem();
            }
            else
            {
                Console.WriteLine("Incorrect. Enter 1 to try again or press RETURN to return to MAIN MENU.");
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

        static void AddItem()
        {
            string choice = "";
            string choice2 = "";
            Console.WriteLine("\n\nADD MENU ITEM\n\nAdd new menu item? (y/n)");
            choice2 = Console.ReadLine();
            if (choice2 == "n")
            {
                MainMenu();
            }
            do
            {
                Console.Write("Menu item name: ");
                string name = Console.ReadLine();
                Console.Write("Menu item price: ");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Description of menu item: ");
                string description = Console.ReadLine();
                Console.Write("Is item breakfast, lunch, dinner, appetizer or dessert?: ");
                string category = Console.ReadLine();

                MenuItem newItem = new MenuItem(name, price, description, category);

                menuObjects.Add(newItem);

                Console.Write("\n\nAdd another new menu item?(y/n)");
                choice = Console.ReadLine();
            } while (choice == "y");
            MainMenu();
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
        //private string name;
        //private double price;
        //private string description;
        //private string category;
        //private DateTime added;

        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Added { get; set; }

        public MenuItem(string name, double price, string description, string category)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            Added = DateTime.Today;
        }

        public override string ToString()
        {
            return Name + "\n" + Price + "\n" + Category + "\n" + Description + "\nAdded: " + Added;
        }
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

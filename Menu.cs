using System;
namespace WebshopOOP
{
	internal class Menu
	{
        const ConsoleColor cc1 = ConsoleColor.White;
        const ConsoleColor cc2 = ConsoleColor.DarkCyan;
        const ConsoleColor cc3 = ConsoleColor.Black;

        Data data = new();

        public void MainMenu()
        {
            Console.CursorVisible = false;
            List<string> list = new() { "Show Products", "Show Customers", "Show Orders" };
            switch (ShowMenu("\n*** Main Menu*** \n", list))
            {
                case 0:
                    ShowProducts();
                    Console.Clear();
                    break;
                case 1:
                    ShowCustomers();
                    Console.Clear();
                    break;
                case 2:
                    ShowOrders();
                    Console.Clear();
                    break;
                default:
                    break;
            }
        }

        private void ShowOrders()
        {
            ShowMenu("Show All Orders", data.GetOrders());
        }

        private void ShowCustomers()
        {
            ShowMenu("Show All Customers", data.GetCustomers());
        }

        private void ShowProducts()
        {
            int selectedProduct = ShowMenu("Show Products", data.GetProductList());
        }

        public int ShowMenu(string Headline, List<string> menuItems)
        { 
            int selected = 0;
            while (true)
            {
                Console.BackgroundColor = cc3;
                Console.ForegroundColor = cc1;
                Console.Clear();
                Console.WriteLine(Headline);

                foreach (var item in menuItems)
                {
                    if (menuItems.IndexOf(item) == selected)
                    {
                        Console.BackgroundColor = cc2;
                        Console.ForegroundColor = cc1;
                    }
                    else
                    {
                        Console.BackgroundColor = cc1;
                        Console.ForegroundColor = cc2;
                    }
                    Console.WriteLine(item);
                }

                ConsoleKey ck = Console.ReadKey().Key;

                if (ck == ConsoleKey.UpArrow)
                {
                    selected--;
                    if (selected < 0) selected = menuItems.Count - 1;
                }
                else if (ck == ConsoleKey.DownArrow)
                {
                    selected++;
                    if (selected >= menuItems.Count) selected = 0;
                }
                else if (ck == ConsoleKey.Enter || ck == ConsoleKey.Spacebar) return selected;

            }

        }
    }
}


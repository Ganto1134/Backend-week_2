using System.Text;

namespace Bar_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<menu> menuItems = new List<menu>
            {
                new menu(1, "Coca Cola 150 ml", 2.50),
                new menu(2, "Insalata di pollo", 5.20),
                new menu(3, "Pizza Margherita", 10.00),
                new menu(4, "Pizza 4 Formaggi", 12.50),
                new menu(5, "Pz patatine fritte", 3.50),
                new menu(6, "Insalata di riso", 8.00),
                new menu(7, "Frutta di stagione", 5.00),
                new menu(8, "Pizza fritta", 5.00),
                new menu(9, "Piadina vegetariana", 6.00),
                new menu(10, "Panino Hamburger", 7.90)
            };

            ordine order = new ordine();
            bool continueOrdering = true;

            while (continueOrdering)
            {
                PrintMenu(menuItems);

                Console.Write("Seleziona un'opzione: ");
                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    if (option >= 1 && option <= 10)
                    {
                        menu selectedItem = menuItems.Find(item => item.Id == option);
                        order.AddItem(selectedItem);
                        Console.WriteLine($"Hai aggiunto: {selectedItem.Name}");
                    }
                    else if (option == 11)
                    {
                        continueOrdering = false;
                        order.PrintBill();
                    }
                    else
                    {
                        Console.WriteLine("Opzione non valida. Riprova.");
                    }
                }
                else
                {
                    Console.WriteLine("Inserisci un numero valido.");
                }
            }
        }

        static void PrintMenu(List<menu> menuItems)
        {
            Console.WriteLine("==============MENU==============");
            foreach (var item in menuItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("11: Stampa conto finale e conferma");
            Console.WriteLine("==============MENU==============");
        }
    }
}


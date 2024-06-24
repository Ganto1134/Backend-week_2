using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_menu
{
    internal class ordine
    {
        private List<menu> _orderedItems = new List<menu>();
        private const double ServiceCharge = 3.00;

        public void AddItem(menu item)
        {
            _orderedItems.Add(item);
        }

        public void PrintBill()
        {
            Console.WriteLine("==============CONTO FINALE==============");
            foreach (var item in _orderedItems)
            {
                Console.WriteLine(item);
            }

            double total = _orderedItems.Sum(item => item.Price) + ServiceCharge;
            Console.WriteLine($"\nCosto del servizio: € {ServiceCharge:F2}");
            Console.WriteLine($"Totale: € {total:F2}");
            Console.WriteLine("==============CONTO FINALE==============");
        }
    }
}

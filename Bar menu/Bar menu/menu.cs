using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_menu
{
    internal class menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public menu(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Id}: {Name} (€ {Price:F2})";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Models
{
    abstract class Menu
    {
        public Plato Main { get; set; }
        public Plato Second { get; set; }
        public Plato Dessert { get; set; }
        public decimal Price { get; set; }
    }
}

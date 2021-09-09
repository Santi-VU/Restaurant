using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Models
{
    class Infantil : Menu
    {
        public Infantil(Plato Main, Plato Dessert, decimal Price)
        {
            this.Main = Main;
            this.Second = Second;
            this.Dessert = null;
            this.Price = Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Menu Infantil:");
            sb.AppendLine("\t" + this.Main.ToString());
            sb.AppendLine("\t" + this.Dessert.ToString());
            sb.AppendLine("\t" + "Total: " + this.Price.ToString() + "€");

            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Models
{
    class Celiaco : Menu
    {
        public Celiaco(Plato Main, Plato Second, Plato Dessert, decimal Price)
        {
            this.Main = Main;
            this.Second = Second;
            this.Dessert = Dessert;
            this.Price = Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Menú Celiaco:");
            sb.AppendLine("\t" + this.Main.ToString());
            sb.AppendLine("\t" + this.Second.ToString());
            sb.AppendLine("\t" + this.Dessert.ToString());
            sb.AppendLine("\t" + "Total: " + this.Price.ToString() + "€");

            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Models
{
    class Plato
    {
        public string name;

        public Plato(string name) {
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}

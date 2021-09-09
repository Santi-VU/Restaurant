using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Builders
{
    class InfantilBuilder
    {
        public Infantil _infantil;

        public InfantilBuilder() {
            Reset();
        }

        private void Reset() {
            this._infantil = new Infantil(new Plato("") , new Plato(""), 15);
        }

        public InfantilBuilder SetMain(string main) {
            this._infantil.Main = new Plato(main);
            return this;
        }

        public InfantilBuilder SetDessert(string dessert)
        {
            this._infantil.Dessert = new Plato(dessert);
            return this;
        }

        public Infantil Build() {
            return this._infantil;
        }
    }
}

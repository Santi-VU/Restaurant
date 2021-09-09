using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Builders
{
    class VeganoBuilder
    {
        public Vegano _Vegano;

        public VeganoBuilder() {
            Reset();
        }

        private void Reset() {
            this._Vegano = new Vegano(new Plato(""), new Plato(""), new Plato(""), 30);
        }

        public VeganoBuilder SetMain(string main) {
            this._Vegano.Main = new Plato(main);
            return this;
        }

        public VeganoBuilder SetSecond(string second)
        {
            this._Vegano.Second = new Plato(second);
            return this;
        }

        public VeganoBuilder SetDessert(string dessert)
        {
            this._Vegano.Dessert = new Plato(dessert);
            return this;
        }

        public Vegano Build() {
            return this._Vegano;
        }
    }
}

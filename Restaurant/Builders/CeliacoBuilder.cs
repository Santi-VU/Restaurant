using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Builders
{
    class CeliacoBuilder
    {
        public Celiaco _celiaco;

        public CeliacoBuilder() {
            Reset();
        }

        private void Reset() {
            this._celiaco = new Celiaco(new Plato(""), new Plato(""), new Plato(""), 25);
        }

        public CeliacoBuilder SetMain(string main) {
            this._celiaco.Main = new Plato(main);
            return this;
        }

        public CeliacoBuilder SetSecond(string second)
        {
            this._celiaco.Second = new Plato(second);
            return this;
        }

        public CeliacoBuilder SetDessert(string dessert)
        {
            this._celiaco.Dessert = new Plato(dessert);
            return this;
        }

        public Celiaco Build() {
            return this._celiaco;
        }
    }
}

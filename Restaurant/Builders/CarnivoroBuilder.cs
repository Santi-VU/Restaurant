using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Builders
{
    class CarnivoroBuilder
    {
        public Carnivoro _carnivoro;

        public CarnivoroBuilder() {
            Reset();
        }

        private void Reset() {
            this._carnivoro = new Carnivoro(new Plato(""), new Plato(""), new Plato(""), 25);
        }

        public CarnivoroBuilder SetMain(string main) {
            this._carnivoro.Main = new Plato(main);
            return this;
        }

        public CarnivoroBuilder SetSecond(string second)
        {
            this._carnivoro.Second = new Plato(second);
            return this;
        }

        public CarnivoroBuilder SetDessert(string dessert)
        {
            this._carnivoro.Dessert = new Plato(dessert);
            return this;
        }

        public Carnivoro Build() {
            return this._carnivoro;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Models
{
    class Carta
    {
        public List<Plato> CarnivoroMain;
        public List<Plato> CarnivoroSecond;

        public List<Plato> VeganMain;
        public List<Plato> VeganSecond;

        public List<Plato> Infantil;

        public List<Plato> Dessert;
        public List<Plato> VeganDessert;

        public Carta() {
            Init();
        }

        private void Init()
        {
            this.CarnivoroMain = new List<Plato>();
            this.CarnivoroMain.Add(new Plato("Tomate de Barbastro"));
            this.CarnivoroMain.Add(new Plato("Croquetas de Jamón"));
            this.CarnivoroMain.Add(new Plato("Ensalada Queso de Cabra"));

            this.CarnivoroSecond = new List<Plato>();
            this.CarnivoroSecond.Add(new Plato("Chuletón vaca gallega"));
            this.CarnivoroSecond.Add(new Plato("Solomillo vaca gallega"));
            this.CarnivoroSecond.Add(new Plato("Entrecot vaca gallega"));

            this.VeganMain = new List<Plato>();
            this.VeganMain.Add(new Plato("Arroz al horno vegano"));
            this.VeganMain.Add(new Plato("Pastel de patata vegetal"));

            this.VeganSecond = new List<Plato>();
            this.VeganSecond.Add(new Plato("Sanjacobos veganos de seitán"));
            this.VeganSecond.Add(new Plato("No pollo a la cerveza"));

            this.Infantil = new List<Plato>();
            this.Infantil.Add(new Plato("Hamburguesa de ternera"));
            this.Infantil.Add(new Plato("Mini Pizza"));

            this.Dessert = new List<Plato>();
            this.Dessert.Add(new Plato("Tarta de queso"));
            this.Dessert.Add(new Plato("Natillas"));
            this.Dessert.Add(new Plato("Flan de huevo"));

            this.VeganDessert = new List<Plato>();
            this.VeganDessert.Add(new Plato("Galletas veganas"));
            this.VeganDessert.Add(new Plato("Magdalena vegana"));
        }
    }
}

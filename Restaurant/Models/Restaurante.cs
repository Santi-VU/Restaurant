using Restaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Models
{
    class Restaurante : IRestauranteable
    {
        static Restaurante restaurante;
        //
        public string nombre;
        public string direccion;
        public string ciudad;
        public int cp;
        public Carta carta;
        public List<Mesa> mesas;
        public Maquina maquina;

        public Restaurante() {

        }

        public static Restaurante GetInstance(string nombre, string direccion, string ciudad, int cp, Maquina maquina)
        {
            if (restaurante == null) {
                restaurante = new Restaurante();

                restaurante.nombre = nombre;
                restaurante.direccion = direccion;
                restaurante.ciudad = ciudad;
                restaurante.cp = cp;
                restaurante.carta = new Carta();
                restaurante.mesas = new List<Mesa>();
                restaurante.maquina = maquina;
            }
            return restaurante;
        }
        /// <summary>
        /// Añade una mesa a la lista
        /// </summary>
        /// <param name="m"></param>
        public void addMesa(Mesa m)
        {
            mesas.Add(m);
        }
    }
}

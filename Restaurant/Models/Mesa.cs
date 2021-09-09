using Restaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Models
{
    class Mesa : IMesaable
    {
        public int id;
        public int comensales;
        public List<Menu> menus;
        public decimal cuenta;

        public Mesa(int id, int comensales) {
            this.id = id;
            this.comensales = comensales;
            Init();
        }
        /// <summary>
        /// Añade menú a la lista
        /// </summary>
        /// <param name="menu"></param>
        public void AddMenu(Menu menu)
        {
            this.menus.Add(menu);
        }
        /// <summary>
        /// Devuelve el total de todos los menús de la lista
        /// </summary>
        /// <returns></returns>
        public decimal CalcularCuenta()
        {
            decimal d = 0;
            foreach (var i in this.menus)
            {
                d += i.Price;
            }
            return d;
        }

        private void Init() {
            this.menus = new List<Menu>();
            this.cuenta = 0;
        }
    }
}

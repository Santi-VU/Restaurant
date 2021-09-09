using Restaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Models
{
    sealed public class Maquina : IMaquinaable
    {
        static Maquina maquina;
        private decimal totalCaja;
        private Maquina()
        {

        }
        public static Maquina GetInstance()
        {
            if (maquina == null)
                maquina = new Maquina();
            return maquina;
        }
        /// <summary>
        /// Añade fondos a la caja registradora
        /// </summary>
        /// <param name="founds"></param>
        public void SumarCaja(decimal founds)
        {
            this.totalCaja = this.totalCaja + founds;
        }
        /// <summary>
        /// Devuelve el total de los fondos de la caja registradora
        /// </summary>
        /// <returns></returns>
        public decimal VerCaja()
        {
            return this.totalCaja;
        }
    }
}

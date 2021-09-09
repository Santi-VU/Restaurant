using Restaurant.Interfaces;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Services
{
    class CobroService 
    {
        public void PasarPorCaja(Restaurante restaurante, StringBuilder sb)
        {
            if (restaurante.mesas == null || restaurante.mesas.Count == 0)
            {
                Console.WriteLine("¡No hay mesas que cobrar!" + "\n");
            }
            else
            {
                Console.WriteLine("Introzuca número de mesa para pagar");
                //int nM = Int32.Parse(Console.ReadLine());
                int nM = 0;
                Int32.TryParse(Console.ReadLine(), out nM);
                if (nM > restaurante.mesas.Count)
                {
                    Console.WriteLine("La mesa número: " + nM + " no está ocupada");
                }
                else
                {
                    sb = new StringBuilder();
                    sb.Append("Mesa número: " + nM + " cobrada correctamente (");
                    sb.Append(restaurante.mesas[nM - 1].CalcularCuenta().ToString() + ")");
                    Console.WriteLine(sb.ToString());

                    restaurante.maquina.SumarCaja(restaurante.mesas[nM - 1].CalcularCuenta());
                    restaurante.mesas.Remove(restaurante.mesas[nM - 1]);
                }
            }
        }
    }
}

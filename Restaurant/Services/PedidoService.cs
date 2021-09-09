using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Services
{
    class PedidoService
    {
        public void GenerarPedido(Restaurante restaurante, Mesa mesa, StringBuilder sb)
        {
            sb = new StringBuilder();
            if (restaurante.mesas.Count < 10)
            {
                sb.AppendLine("Gracias por su pedido");
                sb.AppendLine("Su mesa es la número: " + mesa.id.ToString() + ", el total del pedido es: " + mesa.CalcularCuenta());
                restaurante.addMesa(mesa);
            }
            else
            {
                sb.AppendLine("¡No hay mesas disponibles!");
            }
            Console.WriteLine(sb.ToString());
        }

        public void VerPedidoMesa(Restaurante restaurante)
        {
            Console.WriteLine("Introzuca número de mesa");
            int numeroMesa = Int32.Parse(Console.ReadLine());
            if (!ValidarMesa(numeroMesa, restaurante.mesas.Count))
            {
                Console.WriteLine("La mesa número: " + numeroMesa + " no está ocupada");
            }
            else
            {
                foreach (var i in restaurante.mesas[numeroMesa - 1].menus)
                {
                    Console.WriteLine(i.ToString());
                }
                Console.WriteLine(restaurante.mesas[numeroMesa - 1].CalcularCuenta().ToString());
            }
        }

        public bool ValidarMesa(int numeroMesa, int numeroMaximo) {
            if (numeroMesa > numeroMaximo)
            {
                return false;
            }
            return true;
        }
    }
}

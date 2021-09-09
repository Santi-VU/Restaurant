using Restaurant.Builders;
using Restaurant.Models;
using Restaurant.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            // INI - INICIALIZACÏÓN DE VARIABLES
            bool error = false;
            int opcion = -1;
            int opcionMenu = -1;
            int comensales = 0;
            int contadorMesas = 1;
            int opcionPlato = 0;
            //
            StringBuilder sb = new StringBuilder();
            Mesa auxMesa;
            Restaurante Restaurante = Restaurante.GetInstance("Restaurante Prueba", "Calle Zaragoza", "Zaragoza", 50017, Maquina.GetInstance());
            MenuBuilder menuBuilder = new MenuBuilder();
            CobroService cobroService = new CobroService();
            PedidoService pedidoService = new PedidoService();
            // FIN - INICIALIZACÏÓN DE VARIABLES

            while (opcion != 0) {
                // Muestra primeras opciones, variable error controla la modificación de una línea.
                if (error == false )
                    Console.WriteLine(MostrarOpciones(false).ToString());
                else
                    Console.WriteLine(MostrarOpciones(true).ToString());
                if (!Int32.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = -1;
                }
                error = false;

                //Tratamiento de opciones
                if (opcion == 1)
                {
                    // Seleccionar Mesa / Generar Pedido
                    Console.WriteLine("Introzuca Nº de comensales");
                    comensales = Int32.Parse(Console.ReadLine());
                    auxMesa = new Mesa(contadorMesas, comensales);

                    for (int i = 0; i < comensales; i++)
                    {
                        Console.WriteLine(MostrarMenus().ToString());
                        opcionMenu = Int32.Parse(Console.ReadLine());

                        if (opcionMenu == 1)
                        {
                            var o = menuBuilder.setCarnivoroMenu();

                            Console.WriteLine(MostrarCarta(Restaurante, opcionMenu, true, sb).ToString());
                            opcionPlato = Int32.Parse(Console.ReadLine()) - 1;
                            o.SetMain(Restaurante.carta.CarnivoroMain[opcionPlato].ToString());

                            Console.WriteLine(MostrarCarta(Restaurante, opcionMenu, false, sb).ToString());
                            opcionPlato = Int32.Parse(Console.ReadLine()) - 1;
                            o.SetSecond(Restaurante.carta.CarnivoroSecond[opcionPlato].ToString());

                            Console.WriteLine(MostrarCarta(Restaurante, 0, true, sb).ToString());
                            opcionPlato = Int32.Parse(Console.ReadLine()) - 1;
                            o.SetDessert(Restaurante.carta.Dessert[opcionPlato].ToString());

                            auxMesa.AddMenu(o.Build());
                        }
                        else if (opcionMenu == 2)
                        {
                            var o = menuBuilder.setVeganoMenu();

                            Console.WriteLine(MostrarCarta(Restaurante, opcionMenu, true, sb).ToString());
                            opcionPlato = Int32.Parse(Console.ReadLine()) - 1;
                            o.SetMain(Restaurante.carta.VeganMain[opcionPlato].ToString());

                            Console.WriteLine(MostrarCarta(Restaurante, opcionMenu, false, sb).ToString());
                            opcionPlato = Int32.Parse(Console.ReadLine()) - 1;
                            o.SetSecond(Restaurante.carta.VeganSecond[opcionPlato].ToString());

                            Console.WriteLine(MostrarCarta(Restaurante, 0, false, sb).ToString());
                            opcionPlato = Int32.Parse(Console.ReadLine()) - 1;
                            o.SetDessert(Restaurante.carta.VeganDessert[opcionPlato].ToString());

                            auxMesa.AddMenu(o.Build());
                        }
                        else {
                            var o = menuBuilder.setInfantilMenu();

                            Console.WriteLine(MostrarCarta(Restaurante, opcionMenu, true, sb).ToString());
                            opcionPlato = Int32.Parse(Console.ReadLine()) - 1;
                            o.SetMain(Restaurante.carta.Infantil[opcionPlato].ToString());

                            Console.WriteLine(MostrarCarta(Restaurante, 0, false, sb).ToString());
                            opcionPlato = Int32.Parse(Console.ReadLine()) - 1;
                            o.SetDessert(Restaurante.carta.Dessert[opcionPlato].ToString());

                            auxMesa.AddMenu(o.Build());
                        }
                    }
                    contadorMesas++;
                    pedidoService.GenerarPedido(Restaurante, auxMesa, sb);
                }
                else if (opcion == 2)
                {
                    // Opción pagar mesa
                    cobroService.PasarPorCaja(Restaurante, sb);
                }
                else if (opcion == 3)
                {
                    // Opción ver pedido de una mesa
                    pedidoService.VerPedidoMesa(Restaurante);
                }
                else if (opcion == 4)
                {
                    // Opción Ver caja total restaurante
                    Console.WriteLine("El total de la caja del restaurante es: " + Restaurante.maquina.VerCaja().ToString() + " €");
                }
                else if (opcion == 0)
                {
                    Console.WriteLine("Saliendo! Gracias");
                }
                else 
                {
                    // Opción no escogida, error -> true, se mostrar
                    error = true;
                }

            }
        }
        /// <summary>
        /// Muestra opciones principales del menú
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        public static StringBuilder MostrarOpciones(bool error) {
            StringBuilder sb = new StringBuilder();
            if (error == false)
                sb.AppendLine("Seleccione opción");
            else
                sb.AppendLine("Hubo un error, seleccione opción nuevamente");
            sb.AppendLine("1) Sentarse en mesa");
            sb.AppendLine("2) Pagar Cuenta");
            sb.AppendLine("3) Ver mesa");
            sb.AppendLine("4) Ver total caja");
            sb.AppendLine("0) Salir");
            return sb;
        }
        /// <summary>
        /// Muestra tipos de menús
        /// </summary>
        /// <returns></returns>
        public static StringBuilder MostrarMenus() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Seleccione tipo de menú");
            sb.AppendLine("1) Carnivoro");
            sb.AppendLine("2) Vegano");
            sb.AppendLine("3) Infantil");
            return sb;
        }
        /// <summary>
        /// Muestra los diferentes tipos de carta
        /// </summary>
        /// <param name="Restaurante"></param>
        /// <param name="tipo"></param>
        /// <param name="Main"></param>
        /// <param name="sb"></param>
        /// <returns></returns>
        public static StringBuilder MostrarCarta(Restaurante Restaurante, int tipo, bool Main, StringBuilder sb) {
            sb = new StringBuilder();

            if (tipo == 1)
            {
                if (Main == true)
                    LeerPlatos(sb, Restaurante.carta.CarnivoroMain);
                else
                    LeerPlatos(sb, Restaurante.carta.CarnivoroSecond);
            }
            else if (tipo == 2)
            {
                if (Main == true)
                    LeerPlatos(sb, Restaurante.carta.VeganMain);
                else
                    LeerPlatos(sb, Restaurante.carta.VeganSecond);
            }
            else if (tipo == 3)
            {
                LeerPlatos(sb, Restaurante.carta.Infantil);
            } else {
                if (Main == true)
                    LeerPlatos(sb, Restaurante.carta.Dessert);
                else
                    LeerPlatos(sb, Restaurante.carta.VeganDessert);
            }

            return sb;
        }
        /// <summary>
        /// Recorre forEach de listas de tipo Plato
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static StringBuilder LeerPlatos(StringBuilder sb, List <Plato> lista) {
            int cont = 1;
            foreach (var i in lista)
            {
                sb.AppendLine(cont.ToString() + ") " + i);
                cont++;
            }
            return sb;
        }
    }
}

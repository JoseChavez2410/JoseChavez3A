using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deber3VentaGasolina.Clases;

namespace Deber3VentaGasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            Clientes clientes = new Clientes();
            Gasolina gasolina = new Gasolina();
            int soporte = 0;
            Console.WriteLine("\t\t\t---- PROCESO DE FACTURACIÓN ----");
            Console.WriteLine(" Ingrese los datos del cliente: ");
            Console.WriteLine("");
            Console.Write(" Apellidos: ");
            clientes.Apellidos = Console.ReadLine();
            Console.Write(" Nombres: ");
            clientes.Nombres = Console.ReadLine();
            Console.Write(" Cedula de Identidad: ");
            clientes.Cedula = Console.ReadLine();
            Console.Write(" Dirección: ");
            clientes.Direccion = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ingrese datos de compra: ");
            Console.WriteLine("");
            do
            {          
            Console.WriteLine("Tipo de Gasolina (Extra / Super): ");
                gasolina.Tipo = Console.ReadLine();
                if (gasolina.Tipo=="Extra" || gasolina.Tipo == "Super"
                    || gasolina.Tipo == "extra"|| gasolina.Tipo == "super"
                    || gasolina.Tipo == "EXTRA"|| gasolina.Tipo == "SUPER")
                {
                    soporte = 1;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un tipo de Gasolina valido.");
                } 
            } while (soporte==0);
            Console.WriteLine("Cantidad de galones a comprar: ");
            gasolina.Cantidad=int.Parse(Console.ReadLine());


            Console.WriteLine("\t♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            Console.WriteLine("\t♦                Tercer Nivel Cia. Ltda.               ♦");
            Console.WriteLine("\t♦                        FACTURA                       ♦");
            Console.WriteLine("\t♦                   Venta de Gasolina                  ♦");
            Console.WriteLine("\t♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            Console.WriteLine("\t♦                                                      ♦");
            Console.WriteLine("\t♦                   DATOS DEL CLIENTE                  ♦");
            Console.WriteLine("\t                                                        ");
            Console.WriteLine("\t  Apellidos: {0}                                        " ,clientes.Apellidos);
            Console.WriteLine("\t  Nombres: {0}                                          " ,clientes.Nombres);
            Console.WriteLine("\t  Cédula: {0}                                           " ,clientes.Cedula);
            Console.WriteLine("\t  Dirección: {0}                                        " ,clientes.Direccion);
            Console.WriteLine("\t♦                                                      ♦");
            Console.WriteLine("\t♦                    DATOS DE COMPRA                   ♦");
            Console.WriteLine("\t♦                                                      ♦");
            Console.WriteLine("\t  Tipo de Gasolina: {0}                                 " ,gasolina.Tipo);
            Console.WriteLine("\t  Galones requeridos: {0}                               " ,gasolina.Cantidad);
            Console.WriteLine("\t  Precio por Galón: {0}                                 " ,gasolina.Precio);
            Console.WriteLine("\t                                                        ");
            Console.WriteLine("\t              SUBTOTAL: {0}                             " ,gasolina.Subtotal);
            Console.WriteLine("\t              IVA: {0}                                  " ,gasolina.IVA);
            Console.WriteLine("\t              TOTAL: {0}                                " ,gasolina.Total);
            Console.WriteLine("\t♦                                                      ♦");
            Console.WriteLine("\t♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            Console.ReadKey();
        }
    }

}

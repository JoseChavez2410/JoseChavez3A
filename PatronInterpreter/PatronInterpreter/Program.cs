using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronInterprete.Clases;

namespace PatronInterprete
{
    class Program
    {
        static void Main(string[] args)
        {
            string expresionEvaluar = "MMMCMCV";
            //se crea el objeto contexto y le pasamos la expresion a evaluar
            Contexto contexto = new Contexto(expresionEvaluar);

            //se construye el arbol de parse (parse tree)
            //cada clase corresponde a una regla en la gramatica

            List<Expresion> Arbol = new List<Expresion>();//se hace uso de una lista porque la interpretacion es lineal
            Arbol.Add(new ExpresionMiles());
            Arbol.Add(new ExpresionCentenas());
            Arbol.Add(new ExrpesionDecenas());
            Arbol.Add(new ExpresionUnidad());

            //interpretamos siguiendo las reglas gramaticales que se hallan en el arbol
            foreach (Expresion exp in Arbol)
            {
                exp.Interpretar(contexto);
            }

            Console.WriteLine("\nEl numero romano {0} es {1} en notación decimal", expresionEvaluar, contexto.Valor);
            Console.WriteLine("\n\nPresione cualquier tecla para cerrar.");
            Console.ReadKey();
        }
    }
}

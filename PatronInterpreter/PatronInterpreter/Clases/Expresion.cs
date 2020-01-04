using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronInterprete.Clases
{
    abstract class Expresion
    {

        //La clase Expresion es una clase abstracta
        //Esta clase contiene una serie de metodos  
        public void Interpretar(Contexto pContexto) //Metodo Interpretar, llevara a cabo la interpretacion de la cadena que se halla en la clase Contexto
        {
            if (pContexto.Expresion.Length == 0) //Verificamos que el contexto tenga algo de informacion, si es cero no se lleva a cabo la interpretacion
            {
                return;
            }

            //Verificamos si empieza con nueve
            //StartsWith es un metodo propio de la clase string, nos permite saber si esa cadena empieza con alguna subcadena en particular
            if (pContexto.Expresion.StartsWith(Nueve()))
            {

                //Agregamos el nuevo por la posicion donde este; 1, 10, 100 o 1000
                //Se agrega a Valor el 9 por el factor
                pContexto.Valor += (9 * Factor());

                //eliminamos dos caracteres IX, XC, CM que son 9, 90, 900
                pContexto.Expresion = pContexto.Expresion.Substring(2);
            }

            //Aplica la misma logica anterior para los siguientes metodos

            //Verificamos si empieza con cuatro
            else if (pContexto.Expresion.StartsWith(Cuatro()))
            {
                pContexto.Valor += (4 * Factor());
                pContexto.Expresion = pContexto.Expresion.Substring(2);
            }

            //Verificamos si empieza con cinco
            else if (pContexto.Expresion.StartsWith(Cinco()))
            {
                pContexto.Valor += (5 * Factor());
                pContexto.Expresion = pContexto.Expresion.Substring(1);
            }

            //Recorrido para encontrar las unidades
            //Recorremos las unidades encontradas I, X, C
            //Se usa un while porque con las unidades podemos tener repeticiones, como II, III, XX, XXX o CC, CCC
            while (pContexto.Expresion.StartsWith(Unidad()))
            {
                pContexto.Valor += (1 * Factor());
                pContexto.Expresion = pContexto.Expresion.Substring(1);
            }
        }

        //Tenemos una serie de metodos abstractos, que seran implementados por las clases hijas de Expresion
        //Estos metodos nos serviran para identificar si el fragmento de expresion empezara con una unidad, si empieza con un 4, un 5 o un 9 
        //Se va a ir chequeando cuales son los caracteres que indican que a continuacion se tiene un valor que este empezando con 1, 4, 5 o 9 
        public abstract string Unidad();
        public abstract string Cuatro();
        public abstract string Cinco();
        public abstract string Nueve();
        public abstract int Factor(); //Sirve para saber por que valor se va a multplicar en el interprete
        //Estos metodos seran interpretados por las clases que van a descender de Expresion
    }
}

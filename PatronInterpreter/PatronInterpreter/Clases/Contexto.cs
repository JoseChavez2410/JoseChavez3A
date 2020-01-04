using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronInterprete.Clases
{
    class Contexto
    {
        //esta es la primer clase, la de contexto, contiene lo que deseamos interpretar
        private string expresion;
        private int valor;

        public string Expresion { get => expresion; set => expresion = value; } //propiedades del dato 'expresion'
        public int Valor { get => valor; set => valor = value; } //propiedades del dato 'valor'

        //colocamos la expresion a interpretar
        //el metodo a continuacion es el constructor, esta recibiendo la expresion que deseamos interpretar.
        public Contexto(string pExpresion)
        {
            expresion = pExpresion; //esta es la expresion a interpretar

            Console.WriteLine("Se evaluará {0}", expresion); //mensaje representativo que indicara la expresion a evaluar


        }
    }
}

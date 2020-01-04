using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronInterprete.Clases
{
    class ExpresionMiles : Expresion

    {
        public override string Unidad()
        {
            /*Regresamos el caracter para que sea utilizado por el interprete
              para reconocer y evaluar el valor
            */
            return "M";
        }

        //En los siguientes metodos se regresa una cadena con un espacio 
        //ya que no hay caracteres para la representacion de estos números.
        public override string Cuatro()
        {
            return " ";
        }

        public override string Cinco()
        {
            return " ";
        }

        public override string Nueve()
        {
            return " ";
        }

        public override int Factor()
        {
            //El valor encontrado sera multiplicado por 1000 en el interprete
            return 1000;
        }
    }
}

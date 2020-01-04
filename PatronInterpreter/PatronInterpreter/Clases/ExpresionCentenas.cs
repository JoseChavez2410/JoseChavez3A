using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronInterprete.Clases
{
    class ExpresionCentenas : Expresion
    {
        public override string Unidad()
        {
            /*Regresamos el caracter para que sea utilizado por el interprete
             para reconocer y evaluar el valor
            */
            return "C";
        }

        public override string Cuatro()
        {
            return "CD";
        }

        public override string Cinco()
        {
            return "D";
        }

        public override string Nueve()
        {
            return "CM";
        }

        public override int Factor()
        {
            //El valor encontrado sera multiplicado por 100 en el interprete
            return 100;
        }
    }
}

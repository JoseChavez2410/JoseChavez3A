using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronInterprete.Clases
{
    class ExrpesionDecenas : Expresion
    {
        public override string Unidad()
        {
            /*Regresamos el caracter para que sea utilizado por el interprete
             para reconocer y evaluar el valor
            */
            return "X";
        }

        public override string Cuatro()
        {
            return "XL";
        }

        public override string Cinco()
        {
            return "L";
        }

        public override string Nueve()
        {
            return "XC";
        }

        public override int Factor()
        {
            //El valor encontrado sera multiplicado por 10 en el interprete
            return 10;
        }
    }
}

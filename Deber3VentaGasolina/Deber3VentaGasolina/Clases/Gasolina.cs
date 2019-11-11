using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deber3VentaGasolina.Clases
{
    class Gasolina
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private float precio;

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}

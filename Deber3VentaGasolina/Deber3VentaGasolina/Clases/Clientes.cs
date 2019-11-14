using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deber3VentaGasolina.Clases
{
    public class Clientes
    {
        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private string nombres;

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        private string cedula;

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private List<Gasolina> gasolina;
      
        public List<Gasolina> Gasolina 
        {
            get { return gasolina; }
            set { gasolina = value; }
        }

    }
}

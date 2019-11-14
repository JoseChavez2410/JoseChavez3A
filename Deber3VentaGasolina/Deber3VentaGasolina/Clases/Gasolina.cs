namespace Deber3VentaGasolina.Clases
{
    public class Gasolina
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

        private double precio;

        public double Precio
        {
            get {
                if (Tipo=="Extra"||tipo=="extra"||tipo=="EXTRA")
                {
                    precio= 1.50;
                }
                else if (Tipo=="Super"||tipo=="super"||tipo=="SUPER")
                {
                    precio= 2.00;
                }
                return precio;
            }

        }

        private double subtotal;

        public double Subtotal
        {
            get { return subtotal=precio*cantidad; }
        }

        private double iva;

        public double IVA
        {
            get { return iva=(subtotal*12)/100; }
            set { iva = value; }
        }

        private double total;

        public double Total
        {
            get { return total=subtotal+iva; }
  
        }





    }
}

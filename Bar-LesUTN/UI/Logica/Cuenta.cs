using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_01.Logica
{
    public class Cuenta
    {

        static int ultimaCuenta;

        int idCuenta; 
        List<Producto> pedido;
        bool cuentaCerrada;
        float costo;


        static Cuenta()
        {
            ultimaCuenta = 0;
        }

        public Cuenta(List<Producto> pedido):this()
        {
            this.pedido = pedido;
            this.costo = CalcularCosto(pedido);
        }
        public Cuenta()
        {
            cuentaCerrada = true;
            idCuenta = ultimaCuenta;
            pedido = new List<Producto>();
        }



        private static float CalcularCosto(List<Producto> pedido)
        {
            float costo = 0;
            foreach (Producto item in pedido)
            {
                costo += item.Precio;
            }

            return costo;
        }




    }
}

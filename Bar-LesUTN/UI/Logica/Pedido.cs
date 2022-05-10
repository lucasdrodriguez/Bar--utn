using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_01.Logica
{
    public class Pedido
    {

        int cantidad;
        Producto producto;

        public Pedido(int cantidad, Producto producto)
        {
            this.cantidad = cantidad;
            this.producto = producto;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_01.Logica
{
    public enum EIngredientes
    {
        CarneRoja,
        Pollo,
        Tomate,
        Lechuga,
        Papas,
        Sal,
        SalsaPicante,
        Queso,
        Salchicha,
        Harina,
        Aceitunas
    }
    public class Comida : Producto
    {

        List<EIngredientes> ingredientes;

        public Comida(string nombre, int cantidadDisponible, float precio, List<EIngredientes> ingredientes) : base(nombre, cantidadDisponible, precio)
        {
            this.ingredientes = ingredientes;

        }

        public override bool ReponerProducto(int cantidad)
        {
            if (cantidad > 0)
            {
                PedirAlProveedor = cantidad;
                return true;
            }
            return false;
        }
        protected override int PedirAlProveedor
        {
            set { cantidadDisponible += value; }
        }
    }
}

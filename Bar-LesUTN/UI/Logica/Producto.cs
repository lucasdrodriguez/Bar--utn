using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejemplo_01.Logica
{
    public abstract class Producto
    {
        static int lastId;

        protected int idProducto;
        protected string nombre;
        protected int cantidadDisponible;
        private float precio;


        static Producto()
        {
            lastId = 1;
        }

        protected Producto(string nombre, int cantidadDisponible, float precio)
        {
            this.idProducto = lastId;
            this.nombre = nombre;
            this.cantidadDisponible = cantidadDisponible;
            this.precio = precio;

            lastId++;
        }

        protected abstract int PedirAlProveedor
        {
            set;
        }
        public float Precio { get => precio; }

        public abstract bool ReponerProducto(int cantidad);

        #region Estaticos

        public static bool operator ==(Producto p1, int id)
        {
            return p1.idProducto == id;
        }
        public static bool operator !=(Producto p1, int id)
        {
            return !(p1 == id);
        }
        public static Producto BuscarProducto(List<Producto> lista, int id)
        {
            foreach (Producto item in lista)
                if (item == id) return item;

            return null;
        }
        public static List<Producto> DevolverProductos(List<Producto> lista, Type tipoProducto)
        {
            List<Producto> aux = new List<Producto>();

            foreach (Producto item in lista)
            {
                if (item.GetType() == tipoProducto)
                    aux.Add(item);
            }

            return aux;
        }
        public static List<Producto> DevolverProductos(List<Producto> lista, string nombre)
        {
            List<Producto> aux = new List<Producto>();

            foreach (Producto item in lista)
            {
                if (item.nombre.ToLower().Trim().Contains(nombre.Trim().ToLower()))
                {
                    aux.Add(item);
                }
            }

            return aux;
        }

        #endregion


    }
}
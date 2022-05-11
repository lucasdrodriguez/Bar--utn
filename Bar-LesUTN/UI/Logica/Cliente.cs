using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_01.Logica
{
    public class Cliente
    {
        int idCliente;
        string nombre;
        Cuenta cuenta;

        public Cliente(int numMesa, string nombre, Cuenta cuenta)
        {
            this.idCliente = numMesa;
            this.nombre = nombre;
            this.cuenta = new Cuenta();
        }

        public string Nombre { get => nombre; }
    }
}

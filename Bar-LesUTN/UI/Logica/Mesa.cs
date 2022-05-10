using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_01.Logica
{
    public class Mesa
    {

        int numeroMesa;
        Cliente cliente;

        public Mesa(int numeroMesa, Cliente cliente)
        {
            this.numeroMesa = numeroMesa;
            this.cliente = cliente;
        }

        public Cliente Cliente { get => cliente; set => cliente = value; }
        public int NumeroMesa { get => numeroMesa;  }
    }
}

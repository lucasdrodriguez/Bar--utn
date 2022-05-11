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
        public int NumeroMesa { get => numeroMesa; }
        public bool EsBarra
        {
            get { return numeroMesa > 15; }
        }

        public override string ToString()
        {
            string tipoMesa = EsBarra ? "Barra" : "Mesa";
            StringBuilder info = new StringBuilder();

            info.AppendLine($"{tipoMesa} N° {this.numeroMesa}");

            if (cliente is null)
                info.AppendLine("Mesa vacia");
            else
                info.AppendLine($"Mesa ocupada. Cliente: {cliente.Nombre}");

            return info.ToString();
        }

    }
}

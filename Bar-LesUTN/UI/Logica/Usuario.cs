using System;
using System.Text;

namespace Ejemplo_01.Logica
{

    public enum ERol
    {
        User,
        Admin
    }

    public class Usuario
    {
        int idUsuario;
        string nombre;
        ERol rol;

        public Usuario(int dni, string nombre, ERol rol)
        {
            this.idUsuario = dni;
            this.nombre = nombre;
            this.rol = rol;
        }

        public int Dni
        {
            get { return idUsuario; }
        }
        public string Nombre
        {
            get { return nombre; }
        }

        public ERol Role
        {
            get { return rol; }
        }

      

    }
}

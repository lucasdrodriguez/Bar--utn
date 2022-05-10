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
        string password;
        ERol rol;

        public Usuario(int dni, string nombre,string password, ERol rol)
        {
            this.idUsuario = dni;
            this.password= password;
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

        public bool ComprobarPassword(string datoIngresado)
        {
            return (!string.IsNullOrEmpty(datoIngresado) && datoIngresado.Trim() == password.Trim());
        }
      

    }
}

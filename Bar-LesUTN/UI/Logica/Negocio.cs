using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_01.Logica
{
    public static class Negocio
    {

        static List<Usuario> listaUsuarios;
        static List<Producto> inventario;
        static Mesa[] mesas;

        static Negocio()
        {
            InstanciarMesas();
            InstanciarProductos();
            InstanciarUsuarios();
        }
        private static void InstanciarMesas()
        {
            mesas = new Mesa[15]
            {
              new Mesa(1,null),
              new Mesa(2,null),
              new Mesa(3,null),
              new Mesa(4,null),
              new Mesa(5,null),
              new Mesa(6,null),
              new Mesa(7,null),
              new Mesa(8,null),
              new Mesa(9,null),
              new Mesa(10,null),
              new Mesa(11,null),
              new Mesa(12,null),
              new Mesa(13,null),
              new Mesa(14,null),
              new Mesa(15,null)
            };


        }
        private static void InstanciarUsuarios()
        {
            listaUsuarios = new List<Usuario>()
            {
                new Usuario(33112312,"Pepe Peposo",ERol.User),
                new Usuario(25097323,"Juana RoyalCanin",ERol.Admin),

            };


        }
        private static void InstanciarProductos()
        {
            inventario = new List<Producto>()
            {
              new Bebida(nombre:"Coca Cola",cantidadDisponible:95,precio: 450,tieneAlcohol: false,formato: EVersionBebida.BotellaDosLitros),
              new Bebida(nombre:"Coca Cola",cantidadDisponible:101,precio: 350,tieneAlcohol: false,formato: EVersionBebida.BotellaLitro),
              new Bebida(nombre:"Brahma",cantidadDisponible:500,precio: 270,tieneAlcohol: true,formato: EVersionBebida.LataGrande),
              new Bebida(nombre:"Andes",cantidadDisponible:10,precio: 340,tieneAlcohol: true,formato: EVersionBebida.BotellaLitro),

              new Comida(nombre:"Hambur Completa",cantidadDisponible:20,precio:600,new List<EIngredientes>(){ EIngredientes.CarneRoja,EIngredientes.Lechuga,EIngredientes.Queso,EIngredientes.Tomate}),
              new Comida(nombre:"Hambur Suprema",cantidadDisponible:21,precio:580,new List<EIngredientes>(){ EIngredientes.Pollo,EIngredientes.Lechuga,EIngredientes.Queso,EIngredientes.Tomate}),
              new Comida(nombre:"Entradadita",cantidadDisponible:200,precio:300,new List<EIngredientes>(){ EIngredientes.Aceitunas,EIngredientes.Queso,EIngredientes.Papas,EIngredientes.Salchicha})
            };

        }








    }
}

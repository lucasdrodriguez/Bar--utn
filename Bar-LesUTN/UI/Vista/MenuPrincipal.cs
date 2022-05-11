using Ejemplo_01.Logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejemplo_01.Vista
{
    public partial class MenuPrincipal : Form
    {
        Usuario usuarioLogueado;
        Dictionary<int, Button> botones;
        Dictionary<int, bool> disponibilidadMesas;
        
        private MenuPrincipal()
        {
            InitializeComponent();
            botones = new Dictionary<int, Button>();
            CargarMesas();
        }

        public MenuPrincipal(Usuario usuario) : this()
        {
            usuarioLogueado = usuario;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
         
            ObtenerEstadoMesas();
        }

        private void CargarMesas()
        {

            botones.Add(1, this.btn_mesa1);
            botones.Add(2, this.btn_mesa2);
            botones.Add(3, this.btn_mesa3);
            botones.Add(4, this.btn_mesa4);
            botones.Add(5, this.btn_mesa5);
            botones.Add(6, this.btn_mesa6);
            botones.Add(7, this.btn_mesa7);
            botones.Add(8, this.btn_mesa8);
            botones.Add(9, this.btn_mesa9);
            botones.Add(10, this.btn_mesa10);
            botones.Add(11, this.btn_mesa11);
            botones.Add(12, this.btn_mesa12);
            botones.Add(13, this.btn_mesa13);
            botones.Add(14, this.btn_mesa14);
            botones.Add(15, this.btn_mesa15);
            botones.Add(16, this.btn_barra16);
            botones.Add(17, this.btn_barra17);
            botones.Add(18, this.btn_barra18);
            botones.Add(19, this.btn_barra19);
            botones.Add(20, this.btn_barra20);

        }
        
        private void ObtenerEstadoMesas()
        {
            disponibilidadMesas = Negocio.EstadoMesas();

            foreach (KeyValuePair<int, bool> mesa in disponibilidadMesas)
            {
                if (mesa.Value)
                    botones[mesa.Key].BackColor = Color.Green;
                else
                    botones[mesa.Key].BackColor = Color.IndianRed;
            }
        }

        private void InfoMesa(string info)
        {
            MessageBox.Show(info);
        }

       
        private void btn_mesa_Click(object sender, EventArgs e)
        {
            Button auxBtn = (Button)sender;

            foreach (KeyValuePair<int, Button> item in botones)
            {
                if (item.Value == auxBtn)
                {
                    InfoMesa(Negocio.MostrarInformacionMesa(item.Key));
                }
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}

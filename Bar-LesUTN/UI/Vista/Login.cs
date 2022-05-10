using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejemplo_01.Logica;

namespace Ejemplo_01.Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_usuario.Text, out int id))
            {
                Usuario userLogueado = Negocio.LoguearUsuario(id, txt_pass.Text);
                
                if(userLogueado is not null)
                {
                    MenuPrincipal mp = new MenuPrincipal(userLogueado);
                    mp.Show();
                    this.Hide();
                }

            }
        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
            this.txt_usuario.Text = "33112312";
            this.txt_pass.Text = "ruf123";
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.txt_usuario.Text = "25097323";
            this.txt_pass.Text = "MadeINLanus";
        }
    }
}

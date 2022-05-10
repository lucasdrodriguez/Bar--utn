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
    public partial class MenuPrincipal : Form
    {
        Usuario usuarioLogueado;
        private MenuPrincipal()
        {
            InitializeComponent();

        }
        public MenuPrincipal(Usuario usuario):this()
        {
            usuarioLogueado = usuario;
        }

    }
}

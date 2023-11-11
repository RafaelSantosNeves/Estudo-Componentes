using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Veiculos : Form
    {
        F_principal fp;

        public F_Veiculos(string v, F_principal f)
        {
            InitializeComponent();
            tb_listaVeiculos.Text = v;

            fp = f;
            f.num = 10;
        }

        private void F_Veiculos_Load(object sender, EventArgs e)
        {

        }

        private void tb_listaVeiculos_TextChanged(object sender, EventArgs e)
        {
            fp.tb_listaVeiculos.Text = tb_listaVeiculos.Text;
        }
    }
}

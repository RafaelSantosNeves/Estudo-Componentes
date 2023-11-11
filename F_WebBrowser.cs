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
    public partial class F_WebBrowser : Form
    {
        public F_WebBrowser()
        {
            InitializeComponent();
        }

        private void Navegar()
        {
            if (tb_url.Text != "")
            {
                webBrowser1.Navigate(tb_url.Text);
            }
            else
            {
                MessageBox.Show("Digite uma url");
                tb_url.Focus();
            }
        }

        private void btn_ir_Click(object sender, EventArgs e)
        {
                Navegar();
        }

        private void tb_url_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) {
                Navegar();
            }
        }
    }
}

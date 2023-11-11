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
    public partial class F_ListBox : Form
    {
        List<string> carros = new List<string>();

        private void Atualiza(ListBox c, List<string> l)
        {
            c.DataSource = null;
            c.DataSource = l;
        }
        public F_ListBox()
        {
            InitializeComponent();
            carros.AddRange(new string[] { "HRV", "Golf", "Focus" });

            lb_carros.DataSource = carros;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_carro.Text.Length > 0) {
                if (!carros.Contains(tb_carro.Text)) {
                    carros.Add(tb_carro.Text);
                    Atualiza(lb_carros,carros);

                    tb_carro.Clear();
                    tb_carro.Focus();
                }
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(lb_carros.SelectedIndex);
            Atualiza(lb_carros, carros);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_carro.Text = carros[lb_carros.SelectedIndex];
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            Atualiza(lb_carros, carros);
        }
    }
}

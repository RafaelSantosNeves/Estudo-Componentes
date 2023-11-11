﻿using System;
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
    public partial class F_TabControl : Form
    {
        public F_TabControl()
        {
            InitializeComponent();
        }

        private void btn_novaTab_Click(object sender, EventArgs e)
        {
            if(tb_nomeNovaTab.Text.Length > 0)
            {
                TabPage pagina = new TabPage();
                pagina.Text = tb_nomeNovaTab.Text;
                pagina.Name = tb_nomeNovaTab.Text;
                pagina.TabIndex = tabControl1.TabPages.Count;
                tabControl1.TabPages.Add(pagina);
                tb_nomeNovaTab.Clear();
                DefinirMaximo();
            }
            else
            {
                MessageBox.Show("Digite o nome da nova Tab");
                tb_nomeNovaTab.Focus();
            }
        }

        private void btn_removerTabAtual_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            DefinirMaximo();
        }

        private void btn_posicionarTab_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value -1 < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = Int32.Parse(numericUpDown1.Value.ToString()) - 1;
            }
        }

        private void DefinirMaximo()
        {
            numericUpDown1.Maximum = tabControl1.TabPages.Count;
        }

        private void F_TabControl_Load(object sender, EventArgs e)
        {
            DefinirMaximo();
            numericUpDown1.Minimum = 1;
        }
    }
}

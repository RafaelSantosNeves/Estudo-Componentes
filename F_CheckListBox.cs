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
    public partial class F_CheckListBox : Form
    {
        public F_CheckListBox()
        {
            InitializeComponent();
        }

        private void F_CheckListBox_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach(string t in clb_transportes.CheckedItems)
            {
                txt += t + ", ";
            }

            MessageBox.Show(txt);
        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_resetarLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
            //clb_transportes.items.add("carro", false);
            //clb_transportes.items.add("avião", false);
            //clb_transportes.items.add("navio", false);
            //clb_transportes.items.add("ônibus", false);
            //clb_transportes.items.add("trem", false);


            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ônibus");
            tr.Add("Trem");

            clb_transportes.Items.AddRange(tr.ToArray());
        }

        private void btn_addNovoTransporte_Click(object sender, EventArgs e)
        {
            if(tb_novoTransporte.Text.Length > 0)
            {
                clb_transportes.Items.Add(tb_novoTransporte.Text);
                tb_novoTransporte.Clear();
                tb_novoTransporte.Focus();
            }
        }
    }
}

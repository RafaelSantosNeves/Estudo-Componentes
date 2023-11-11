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
    public partial class F_TreeView : Form
    {
        public F_TreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox1.Text = treeView1.SelectedNode.Text;
            if(treeView1.SelectedNode.Tag != null)
            {
                textBox2.Text = treeView1.SelectedNode.Tag as string;
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            TreeNode raizEstado = treeView1.Nodes.Add("Estado");
            raizEstado.Name = "raizEstados";

            TreeNode raizCores = treeView1.Nodes.Add("Cores");
            raizCores.Name = "raizCores";

            TreeNode estado1 = raizEstado.Nodes.Add("Minas Gerais");
            estado1.Name = "Minhas Gerais";

            TreeNode estado2 = raizEstado.Nodes.Add("Rio de Janeiro");
            estado1.Name = "Rio de Janeiro";

            TreeNode estado3 = raizEstado.Nodes.Add("São Paulo");
            estado1.Name = "Sao Paulo";
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.Nodes["raizEstados"]);
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao remover nó." + ex.ToString());
            }
        }

        private void btn_removerSelecionado_Click(object sender, EventArgs e)
        {
            if(treeView1.Nodes.Count > 0)
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
            else
            {
                MessageBox.Show("Nao há mais nodes para remover!");
            }

        }
    }
}

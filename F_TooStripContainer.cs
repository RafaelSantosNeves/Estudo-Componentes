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
    public partial class F_TooStripContainer : Form
    {
        public F_TooStripContainer()
        {
            InitializeComponent();
        }

        private void F_TooStripContainer_Load(object sender, EventArgs e)
        {
            List<ToolStrip> bf = new List<ToolStrip>();
            int num = toolStripContainer1.TopToolStripPanel.Controls.Count;

            for(int i = 0; i < num; i++)
            {
                checkedListBox1.Items.Add(toolStripContainer1.TopToolStripPanel.Controls[i].Name);
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Obtém o controle atual
            Control controle = toolStripContainer1.TopToolStripPanel.Controls[e.Index];

            // Inverte o valor da propriedade Visible
            controle.Visible = !controle.Visible;

        }



    }
}

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
    public partial class F_RadioButton : Form
    {
        public F_RadioButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text);
            textBox1.Text = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(RadioButton rb in groupBox1.Controls)
            {
                if(rb.Checked)
                {
                    MessageBox.Show(rb.Text);
                    textBox1.Text = rb.Text;
                }
            }
        }
    }
}

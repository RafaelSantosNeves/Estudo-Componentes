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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            ll_multiplosLinks.Links.Add(0,6,"https://www.bing.com");
            ll_multiplosLinks.Links.Add(7, 5, "https://youtube.com/@DevRafaelSantosNeves?si=3ZqIsG50wtcaNABv");
            ll_multiplosLinks.Links.Add(13, 7, "https://www.youtube.com/");

            ll_multiplosLinks.Links[2].Enabled = false;

        }

        private void ll_canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com/@DevRafaelSantosNeves?si=3ZqIsG50wtcaNABv");
            ll_canal.LinkVisited = true;
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel ll = (LinkLabel)sender;
            ll.LinkVisited = true;
            System.Diagnostics.Process.Start("calc.exe");

        }

        private void ll_multiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }
    }
}

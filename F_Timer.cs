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
    public partial class F_Timer : Form
    {
        int num;
        int velocidade = 2;
        public F_Timer()
        {
            InitializeComponent();
        }

        private void F_Timer_Load(object sender, EventArgs e)
        {
            num = 0;
        }

        private void btn_iniciarT1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
        }

        private void btn_pararT1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num++;
            label1.Text = num.ToString();
        }

        private void bt_reiniciarT1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            label1.Text = num.ToString();
            timer1.Start();
        }

        private void bt_iniciarCarro_Click(object sender, EventArgs e)
        {
            timer_carro.Interval = 1;
            timer_carro.Start();
        }

        private void timer_carro_Tick(object sender, EventArgs e)
        {
            Point posicaoAtual = pictureBox1.Location;
            Point novaPosicao = new Point(posicaoAtual.X + velocidade, posicaoAtual.Y);

            posicaoAtual = novaPosicao;
            pictureBox1.Location = novaPosicao;

            if(posicaoAtual.X > 700)
            {
                timer_carro.Stop();
                pictureBox1.Location = new Point(12, posicaoAtual.Y);
            }
        }

        private void bt_pararCarro_Click(object sender, EventArgs e)
        {
            timer_carro.Stop();
        }
    }
}

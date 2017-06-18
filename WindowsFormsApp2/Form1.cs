using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Gato : Form
    {
        int currentUser; //el usuario es 0 la maquina 1.
        public Gato()
        {
            InitializeComponent();
            currentUser = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            currentUser = 0;
            Juego.ECCI_JuegoPortClient jc = new Juego.ECCI_JuegoPortClient();
            MessageBox.Show(jc.salude("Juan"));          
            MessageBox.Show(jc.ultimoSaludo());          
        }

        private void bnt1_Click(object sender, EventArgs e)
        {
            String mark = currentUser == 0 ? "X" : "O";
            currentUser = (currentUser + 1) % 2;
            this.bnt1.Text = mark;
            this.bnt1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            String mark = currentUser == 0 ? "X" : "O";
            currentUser = (currentUser + 1) % 2;
            this.btn2.Text = mark;
            this.btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            String mark = currentUser == 0 ? "X" : "O";
            currentUser = (currentUser + 1) % 2;
            this.btn3.Text = mark;
            this.btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            String mark = currentUser == 0 ? "X" : "O";
            currentUser = (currentUser + 1) % 2;
            this.btn4.Text = mark;
            this.btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            String mark = currentUser == 0 ? "X" : "O";
            currentUser = (currentUser + 1) % 2;
            this.btn5.Text = mark;
            this.btn5.Enabled = false;
        }


        private void btn6_Click(object sender, EventArgs e)
        {
            String mark = currentUser == 0 ? "X" : "O";
            currentUser = (currentUser + 1) % 2;
            this.btn6.Text = mark;
            this.btn6.Enabled = false;
        }


        private void btn7_Click(object sender, EventArgs e)
        {
            String mark = currentUser == 0 ? "X" : "O";
            currentUser = (currentUser + 1) % 2;
            this.btn7.Text = mark;
            this.btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            String mark = currentUser == 0 ? "X" : "O";
            currentUser = (currentUser + 1) % 2;
            this.btn8.Text = mark;
            this.btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            String mark = currentUser == 0 ? "X" : "O";
            currentUser = (currentUser + 1) % 2;
            this.btn9.Text = mark;
            this.btn9.Enabled = false;
        }
    }
}

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
        Juego.ECCI_JuegoPortClient gameClient;
        public Gato()
        {
            InitializeComponent();
            currentUser = 0;
            //se crea la conexión con el servidor
            gameClient = new Juego.ECCI_JuegoPortClient();
            MessageBox.Show(gameClient.salude("Juan"));
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            String mark = currentUser == 0 ? "X" : "O";
            currentUser = (currentUser + 1) % 2;
            this.btn1.Text = mark;
            this.btn1.Enabled = false;
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            currentUser = 0;
            this.tlpGame.Enabled = true;
        }


        private void btnFinish_Click(object sender, EventArgs e)
        {
            currentUser = 0;
            clearButtons();
            tlpGame.Enabled = false;
        }


        //Complementary methods
        public void clearButtons()
        {
            this.btn1.Text = "";
            this.btn1.Enabled = true;
            this.btn2.Text = "";
            this.btn2.Enabled = true;
            this.btn3.Text = "";
            this.btn3.Enabled= true;
            this.btn4.Text = "";
            this.btn4.Enabled = true;
            this.btn5.Text = "";
            this.btn5.Enabled = true;
            this.btn6.Text = "";
            this.btn6.Enabled = true;
            this.btn7.Text = "";
            this.btn7.Enabled = true;
            this.btn8.Text = "";
            this.btn8.Enabled = true;
            this.btn9.Text = "";
            this.btn9.Enabled = true;

        }

    }
}

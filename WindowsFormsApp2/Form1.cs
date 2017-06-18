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
        public Gato()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Juego.ECCI_JuegoPortClient jc = new Juego.ECCI_JuegoPortClient();
            MessageBox.Show(jc.salude("Juan"));          
            MessageBox.Show(jc.ultimoSaludo());          
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapadePresentacionApp
{

    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }
        //abrir paint 
        private void button2_Click(object sender, EventArgs e)
        {
            FPaint paint = new FPaint();
            paint.Show();
            this.Hide();
        }
        //abrir editor de texto
        private void button1_Click(object sender, EventArgs e)
        {
         
            FEditText EditT = new FEditText();
            EditT.Show();
            this.Hide();
        }
        //Cerrar Formulario Principal
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

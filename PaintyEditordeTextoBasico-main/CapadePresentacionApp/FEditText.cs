using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapadePresentacionApp
{
    public partial class FEditText : Form
    {
        Form1 form = new Form1();
        public FEditText()
        {
            InitializeComponent();
            this.CenterToScreen();
        
          
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //copiar 
            if (textBox1.SelectedText != "")
            {
                Clipboard.SetDataObject(textBox1.SelectedText);
            }
               
           
        }
        //pegar
        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();

            if (iData.GetDataPresent(DataFormats.Text))
            {
                String texto = iData.GetData(DataFormats.Text).ToString();

                textBox1.Text = textBox1.Text.Insert(textBox1.SelectionStart, texto);

                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.SelectionLength = 0;
            }
        }
        //Cortar
        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                Clipboard.SetDataObject(textBox1.SelectedText);
                
                textBox1.SelectedText = "";
            }
                
        }
        //Guardar archivo 
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog guardarArchivo = new SaveFileDialog() {Filter= "Text Documents|*.txt", ValidateNames= true })
            {
                
                if (guardarArchivo.ShowDialog()==DialogResult.OK)
                {       
                    using(StreamWriter escribirArchivo = new StreamWriter(guardarArchivo.FileName))
                    {
                        escribirArchivo.WriteLine(textBox1.Text);
                        MessageBox.Show("Archivo Guardado, correctamente","Message", MessageBoxButtons.OK , MessageBoxIcon.Information);
                    }
                }
            }
        }//abrir archivo
        private  void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog buscadorArchivo = new OpenFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true, Multiselect = false })
            {
//Guardar el archivo
                if (buscadorArchivo.ShowDialog() == DialogResult.OK)
                {
                    using(StreamReader archivoLeer = new StreamReader(buscadorArchivo.FileName))
                    {
                        textBox1.Text = archivoLeer.ReadToEnd();
                    }
                }
            }
        }
        //Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
            
        }
        //Despues que se selecciona una opcion si se cierra
        private void FEditText_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        //Modifivar texto
        private void letraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();

            DialogResult fontResult = fontDialog1.ShowDialog();

            if (fontResult == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void FEditText_Load(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

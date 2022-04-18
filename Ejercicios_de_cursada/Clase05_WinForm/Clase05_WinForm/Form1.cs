using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase05_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 miForm = new Form2();
            miForm.ShowDialog();
        }

       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("Desea cerrar el formulario?","Cierre",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Stop);
                if(resultado != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox txtNuevo = new TextBox();
            txtNuevo.Text = "Hola Mundo";
            txtNuevo.Location = new Point(10, 45);
            txtNuevo.Name = "txtAgregado";

            this.Controls.Add(txtNuevo);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

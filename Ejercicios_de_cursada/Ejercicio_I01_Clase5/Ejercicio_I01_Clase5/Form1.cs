using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I01_Clase5
{
    public partial class frmSaludar : Form
    {
        public frmSaludar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtApellido.Text) && !string.IsNullOrEmpty(this.txtNombre.Text)){
                frmSaludo frm = new frmSaludo("Hola Windows form!", $"Soy {this.txtNombre.Text} {this.txtApellido.Text} y mi materia favorita es {this.cmbMateriaFavorita.SelectedItem}");
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show($"Se debe completar los siguientes campos \n {this.txtNombre.Name} \n {this.txtApellido.Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lblError.Visible = false;
            if(char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                this.lblError.Visible=true;
            }
            else
            {
                e.Handled = false;
                this.lblError.Visible=false;
            }
        }
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSaludar_Load(object sender, EventArgs e)
        {
            this.cmbMateriaFavorita.Items.Add("Programacion II");
            this.cmbMateriaFavorita.Items.Add("Laboratorio II");
            this.cmbMateriaFavorita.SelectedIndex = 0;
        }
    }
}

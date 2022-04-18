using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ingresantes;
namespace Ejercicio_I02_Clase5
{
    public partial class frmRegistro : Form
    {
        
        public frmRegistro()
        {

            InitializeComponent();
            lstbPais.Items.Add("Argentina");
            lstbPais.Items.Add("Paraguay");
            lstbPais.Items.Add("Chile");
            rdbMasculino.Checked = true;


        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            int edad = (int)numEdad.Value;
            
            Ingresante persona = new Ingresante(txtNombre.Text, txtDireccion.Text, CheckGenero(), lstbPais.SelectedItem.ToString(),CheckCursos(),edad);
            MessageBox.Show(persona.Mostrar());
        }

        private string CheckGenero()
        {
            string genero;
            if (rdbMasculino.Checked)
            {
                genero = "Masculino";
            }
            else if (rbtFemenino.Checked)
            {
                genero = "Femenino";
            }
            else
            {
                genero = "No Binario";
            }
            return genero;
        }

        private string[] CheckCursos()
        {
            string[] cursos = new string[3];
            int indice = 0;

            if (chkCMasMas.Checked)
            {
                cursos[indice] = "C++";
                indice++;
            }
            if (chkCSharp.Checked)
            {
                cursos[indice] = "C#";
                indice++;
            }
            if (chkJavascript.Checked)
            {
                cursos[indice] = "JavaScript";
                indice++;
            }
            return cursos;
        }
    }
}

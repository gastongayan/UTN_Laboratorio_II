using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContadorPalabras
{
    public partial class frmContadorPalabras : Form
    {
        public frmContadorPalabras()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> diccionario = ObtenerContadorPalabras();
            List<KeyValuePair<string, int>> lista = diccionario.ToList();
            lista.Sort(CompararRepeticiones);
            Mostrar(lista);

        }

        private Dictionary<string, int> ObtenerContadorPalabras()
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            string texto = rchTexto.Text;
            string[] palabras = texto.Split(' ');
            foreach (string palabra in palabras)
            {
                if (diccionario.ContainsKey(palabra))
                {
                    diccionario[palabra]++;
                }
                else
                {
                    diccionario.Add(palabra, 1);
                }
            }




            return diccionario;
        }

        private int CompararRepeticiones(KeyValuePair<string, int> palabra1, KeyValuePair<string, int> palabra2)
        {
            return palabra2.Value - palabra1.Value;
        }
        

        private void Mostrar(List<KeyValuePair<string, int>> lista)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if(lista.Count > 1)
            {
                foreach (KeyValuePair<string, int> palabra in lista)
                {
                    stringBuilder.AppendLine($"{palabra.Key} -- {palabra.Value}");
                }
            }
            else
            {
                stringBuilder.Append("No se ingresaron palabras");
            }
            
            MessageBox.Show(stringBuilder.ToString(), "Podio");
        }
    }
}

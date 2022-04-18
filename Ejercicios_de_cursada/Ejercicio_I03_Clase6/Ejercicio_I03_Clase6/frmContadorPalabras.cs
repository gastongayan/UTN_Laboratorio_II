using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I03_Clase6
{
    public partial class frmContadorPalabras : Form
    {
         


        public Dictionary<string, int> ContarPalabras()
        {
            string texto = rchTexto.Text;
            string[] palabras = texto.Split(' ');
            Dictionary<string, int> diccionario = new Dictionary<string, int>();

            foreach (string palabra in palabras)
            {
                if (!diccionario.ContainsKey(palabra))
                {
                    diccionario.Add(palabra, 1);
                }
                else
                {
                    diccionario[palabra] = 1;
                }
            }

            return diccionario;
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = ContarPalabras();
            List<KeyValuePair<string, int>> listaDescendente = contadorPalabras.ToList();

            listaDescendente.Sort(CompararCantidadRepeticiones);
            MostrarLista(listaDescendente);

        }

        private int CompararCantidadRepeticiones(KeyValuePair<string, int> primerElemento, KeyValuePair<string, int> segundoElemento)
        {
            return segundoElemento.Value - primerElemento.Value;

        }

        private void MostrarLista(List<KeyValuePair<string, int>> listaDescendente)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (KeyValuePair<string, int> dic in listaDescendente)
            {
                stringBuilder.AppendLine($"Palabra: {dic.Key} - Cantidad: {dic.Value}");
            }

            MessageBox.Show(stringBuilder.ToString(), "Lista");
        }

    }
}

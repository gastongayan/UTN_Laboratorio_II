﻿using System;
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
    public partial class frmSaludo : Form
    {

        public frmSaludo()
        {
            InitializeComponent();
        }
        public frmSaludo(string titulo, string mensaje) : this()
        {
            this.lblTitulo.Text = titulo;
            this.lblMensaje.Text = mensaje;
        }



    }
}

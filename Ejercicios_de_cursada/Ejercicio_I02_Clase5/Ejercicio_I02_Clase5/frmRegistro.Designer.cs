namespace Ejercicio_I02_Clase5
{
    partial class frmRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbDetalles = new System.Windows.Forms.GroupBox();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grbGenero = new System.Windows.Forms.GroupBox();
            this.rbtNoBinario = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.grbCursos = new System.Windows.Forms.GroupBox();
            this.chkJavascript = new System.Windows.Forms.CheckBox();
            this.chkCMasMas = new System.Windows.Forms.CheckBox();
            this.chkCSharp = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblPais = new System.Windows.Forms.Label();
            this.lstbPais = new System.Windows.Forms.ListBox();
            this.grbDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.grbGenero.SuspendLayout();
            this.grbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDetalles
            // 
            this.grbDetalles.Controls.Add(this.numEdad);
            this.grbDetalles.Controls.Add(this.txtDireccion);
            this.grbDetalles.Controls.Add(this.txtNombre);
            this.grbDetalles.Controls.Add(this.lblEdad);
            this.grbDetalles.Controls.Add(this.lblDireccion);
            this.grbDetalles.Controls.Add(this.lblNombre);
            this.grbDetalles.Location = new System.Drawing.Point(34, 34);
            this.grbDetalles.Name = "grbDetalles";
            this.grbDetalles.Size = new System.Drawing.Size(242, 158);
            this.grbDetalles.TabIndex = 0;
            this.grbDetalles.TabStop = false;
            this.grbDetalles.Text = "Detalles del usuario:";
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(61, 114);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(171, 23);
            this.numEdad.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(61, 68);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(171, 23);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(61, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(4, 116);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(4, 71);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(4, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // grbGenero
            // 
            this.grbGenero.Controls.Add(this.rbtNoBinario);
            this.grbGenero.Controls.Add(this.rbtFemenino);
            this.grbGenero.Controls.Add(this.rdbMasculino);
            this.grbGenero.Location = new System.Drawing.Point(298, 34);
            this.grbGenero.Name = "grbGenero";
            this.grbGenero.Size = new System.Drawing.Size(116, 109);
            this.grbGenero.TabIndex = 1;
            this.grbGenero.TabStop = false;
            this.grbGenero.Text = "Género";
            // 
            // rbtNoBinario
            // 
            this.rbtNoBinario.AutoSize = true;
            this.rbtNoBinario.Location = new System.Drawing.Point(26, 72);
            this.rbtNoBinario.Name = "rbtNoBinario";
            this.rbtNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rbtNoBinario.TabIndex = 2;
            this.rbtNoBinario.TabStop = true;
            this.rbtNoBinario.Text = "No binario";
            this.rbtNoBinario.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(26, 47);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(78, 19);
            this.rbtFemenino.TabIndex = 1;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(26, 22);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // grbCursos
            // 
            this.grbCursos.Controls.Add(this.chkJavascript);
            this.grbCursos.Controls.Add(this.chkCMasMas);
            this.grbCursos.Controls.Add(this.chkCSharp);
            this.grbCursos.Location = new System.Drawing.Point(298, 149);
            this.grbCursos.Name = "grbCursos";
            this.grbCursos.Size = new System.Drawing.Size(116, 104);
            this.grbCursos.TabIndex = 2;
            this.grbCursos.TabStop = false;
            this.grbCursos.Text = "Cursos";
            // 
            // chkJavascript
            // 
            this.chkJavascript.AutoSize = true;
            this.chkJavascript.Location = new System.Drawing.Point(18, 80);
            this.chkJavascript.Name = "chkJavascript";
            this.chkJavascript.Size = new System.Drawing.Size(78, 19);
            this.chkJavascript.TabIndex = 2;
            this.chkJavascript.Text = "JavaScript";
            this.chkJavascript.UseVisualStyleBackColor = true;
            // 
            // chkCMasMas
            // 
            this.chkCMasMas.AutoSize = true;
            this.chkCMasMas.Location = new System.Drawing.Point(18, 55);
            this.chkCMasMas.Name = "chkCMasMas";
            this.chkCMasMas.Size = new System.Drawing.Size(50, 19);
            this.chkCMasMas.TabIndex = 1;
            this.chkCMasMas.Text = "C++";
            this.chkCMasMas.UseVisualStyleBackColor = true;
            // 
            // chkCSharp
            // 
            this.chkCSharp.AutoSize = true;
            this.chkCSharp.Location = new System.Drawing.Point(18, 30);
            this.chkCSharp.Name = "chkCSharp";
            this.chkCSharp.Size = new System.Drawing.Size(41, 19);
            this.chkCSharp.TabIndex = 0;
            this.chkCSharp.Text = "C#";
            this.chkCSharp.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(295, 290);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(119, 35);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(34, 198);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "Pais";
            // 
            // lstbPais
            // 
            this.lstbPais.FormattingEnabled = true;
            this.lstbPais.ItemHeight = 15;
            this.lstbPais.Location = new System.Drawing.Point(34, 216);
            this.lstbPais.Name = "lstbPais";
            this.lstbPais.Size = new System.Drawing.Size(242, 109);
            this.lstbPais.TabIndex = 5;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 350);
            this.Controls.Add(this.lstbPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.grbCursos);
            this.Controls.Add(this.grbGenero);
            this.Controls.Add(this.grbDetalles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRegistro";
            this.Text = "Registro";
            this.grbDetalles.ResumeLayout(false);
            this.grbDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.grbGenero.ResumeLayout(false);
            this.grbGenero.PerformLayout();
            this.grbCursos.ResumeLayout(false);
            this.grbCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDetalles;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grbGenero;
        private System.Windows.Forms.GroupBox grbCursos;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ListBox lstbPais;
        private System.Windows.Forms.RadioButton rbtNoBinario;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.CheckBox chkJavascript;
        private System.Windows.Forms.CheckBox chkCMasMas;
        private System.Windows.Forms.CheckBox chkCSharp;
    }
}

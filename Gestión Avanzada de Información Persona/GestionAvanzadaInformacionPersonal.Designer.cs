namespace Gestión_Avanzada_de_Información_Persona
{
    partial class GestionAvanzadaInformacionPersonal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDatosPersonales = new System.Windows.Forms.TabPage();
            this.tpPreferencias = new System.Windows.Forms.TabPage();
            this.tpVisualización = new System.Windows.Forms.TabPage();
            this.btSalir = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbSexo = new System.Windows.Forms.Label();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbFechaNac = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpDatosPersonales.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btLimpiar);
            this.panel1.Controls.Add(this.btGuardar);
            this.panel1.Controls.Add(this.btSalir);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 631);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDatosPersonales);
            this.tabControl1.Controls.Add(this.tpPreferencias);
            this.tabControl1.Controls.Add(this.tpVisualización);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1174, 521);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tpDatosPersonales
            // 
            this.tpDatosPersonales.BackColor = System.Drawing.Color.BlueViolet;
            this.tpDatosPersonales.Controls.Add(this.label1);
            this.tpDatosPersonales.Controls.Add(this.numericUpDown1);
            this.tpDatosPersonales.Controls.Add(this.lbFechaNac);
            this.tpDatosPersonales.Controls.Add(this.monthCalendar1);
            this.tpDatosPersonales.Controls.Add(this.panel2);
            this.tpDatosPersonales.Controls.Add(this.lbCorreo);
            this.tpDatosPersonales.Controls.Add(this.lbDireccion);
            this.tpDatosPersonales.Controls.Add(this.lbNombre);
            this.tpDatosPersonales.Controls.Add(this.tbDireccion);
            this.tpDatosPersonales.Controls.Add(this.tbCorreo);
            this.tpDatosPersonales.Controls.Add(this.tbNombre);
            this.tpDatosPersonales.Location = new System.Drawing.Point(4, 25);
            this.tpDatosPersonales.Name = "tpDatosPersonales";
            this.tpDatosPersonales.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatosPersonales.Size = new System.Drawing.Size(1166, 492);
            this.tpDatosPersonales.TabIndex = 0;
            this.tpDatosPersonales.Text = "Datos personales";
            // 
            // tpPreferencias
            // 
            this.tpPreferencias.Location = new System.Drawing.Point(4, 25);
            this.tpPreferencias.Name = "tpPreferencias";
            this.tpPreferencias.Padding = new System.Windows.Forms.Padding(3);
            this.tpPreferencias.Size = new System.Drawing.Size(992, 609);
            this.tpPreferencias.TabIndex = 1;
            this.tpPreferencias.Text = "Preferencias";
            this.tpPreferencias.UseVisualStyleBackColor = true;
            // 
            // tpVisualización
            // 
            this.tpVisualización.Location = new System.Drawing.Point(4, 25);
            this.tpVisualización.Name = "tpVisualización";
            this.tpVisualización.Size = new System.Drawing.Size(992, 609);
            this.tpVisualización.TabIndex = 2;
            this.tpVisualización.Text = "Visualización";
            this.tpVisualización.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(812, 534);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(361, 97);
            this.btSalir.TabIndex = 2;
            this.btSalir.Text = "SALIR";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(7, 534);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(361, 97);
            this.btGuardar.TabIndex = 3;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.UseVisualStyleBackColor = true;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.Location = new System.Drawing.Point(412, 534);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(361, 97);
            this.btLimpiar.TabIndex = 4;
            this.btLimpiar.Text = "LIMPIAR";
            this.btLimpiar.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(265, 31);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(121, 40);
            this.tbNombre.TabIndex = 0;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(265, 166);
            this.tbCorreo.Multiline = true;
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(121, 40);
            this.tbCorreo.TabIndex = 1;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(265, 100);
            this.tbDireccion.Multiline = true;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(121, 40);
            this.tbDireccion.TabIndex = 2;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(64, 45);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(96, 26);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(64, 114);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(109, 26);
            this.lbDireccion.TabIndex = 4;
            this.lbDireccion.Text = "Dirección:";
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.Location = new System.Drawing.Point(64, 180);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(195, 26);
            this.lbCorreo.TabIndex = 5;
            this.lbCorreo.Text = "Correo electrónico:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chartreuse;
            this.panel2.Controls.Add(this.rbOtro);
            this.panel2.Controls.Add(this.rbFemenino);
            this.panel2.Controls.Add(this.rbMasculino);
            this.panel2.Controls.Add(this.lbSexo);
            this.panel2.Location = new System.Drawing.Point(558, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 188);
            this.panel2.TabIndex = 7;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.Location = new System.Drawing.Point(17, 9);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(62, 26);
            this.lbSexo.TabIndex = 0;
            this.lbSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(32, 50);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(106, 24);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemenino.Location = new System.Drawing.Point(32, 101);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(103, 24);
            this.rbFemenino.TabIndex = 2;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOtro.Location = new System.Drawing.Point(32, 149);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(63, 24);
            this.rbOtro.TabIndex = 3;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(69, 273);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // lbFechaNac
            // 
            this.lbFechaNac.AutoSize = true;
            this.lbFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaNac.Location = new System.Drawing.Point(69, 245);
            this.lbFechaNac.Name = "lbFechaNac";
            this.lbFechaNac.Size = new System.Drawing.Size(220, 26);
            this.lbFechaNac.TabIndex = 9;
            this.lbFechaNac.Text = "Fecha de nacimiento:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(646, 279);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Edad:";
            // 
            // GestionAvanzadaInformacionPersonal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1177, 631);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionAvanzadaInformacionPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpDatosPersonales.ResumeLayout(false);
            this.tpDatosPersonales.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDatosPersonales;
        private System.Windows.Forms.TabPage tpPreferencias;
        private System.Windows.Forms.TabPage tpVisualización;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbFechaNac;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}


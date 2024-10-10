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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDatosPersonales = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.numberEdad = new System.Windows.Forms.NumericUpDown();
            this.lbFechaNac = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tpPreferencias = new System.Windows.Forms.TabPage();
            this.lbCalificacion = new System.Windows.Forms.Label();
            this.tbsatisfaccion = new System.Windows.Forms.TrackBar();
            this.lbSatisfaccion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.lbHobbies = new System.Windows.Forms.Label();
            this.ckbHobbies = new System.Windows.Forms.CheckedListBox();
            this.ckSuscribirse = new System.Windows.Forms.CheckBox();
            this.tpVisualización = new System.Windows.Forms.TabPage();
            this.lbFechaHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberEdad)).BeginInit();
            this.panel2.SuspendLayout();
            this.tpPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbsatisfaccion)).BeginInit();
            this.tpVisualización.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // btLimpiar
            // 
            this.btLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.Location = new System.Drawing.Point(412, 534);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(361, 97);
            this.btLimpiar.TabIndex = 4;
            this.btLimpiar.Text = "LIMPIAR";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
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
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
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
            this.tpDatosPersonales.Controls.Add(this.numberEdad);
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
            // numberEdad
            // 
            this.numberEdad.Location = new System.Drawing.Point(646, 279);
            this.numberEdad.Name = "numberEdad";
            this.numberEdad.Size = new System.Drawing.Size(120, 22);
            this.numberEdad.TabIndex = 10;
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
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(69, 273);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
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
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(265, 100);
            this.tbDireccion.Multiline = true;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(121, 40);
            this.tbDireccion.TabIndex = 2;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(265, 166);
            this.tbCorreo.Multiline = true;
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(121, 40);
            this.tbCorreo.TabIndex = 1;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(265, 31);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(121, 40);
            this.tbNombre.TabIndex = 0;
            // 
            // tpPreferencias
            // 
            this.tpPreferencias.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tpPreferencias.Controls.Add(this.lbCalificacion);
            this.tpPreferencias.Controls.Add(this.tbsatisfaccion);
            this.tpPreferencias.Controls.Add(this.lbSatisfaccion);
            this.tpPreferencias.Controls.Add(this.label2);
            this.tpPreferencias.Controls.Add(this.cbPais);
            this.tpPreferencias.Controls.Add(this.lbHobbies);
            this.tpPreferencias.Controls.Add(this.ckbHobbies);
            this.tpPreferencias.Controls.Add(this.ckSuscribirse);
            this.tpPreferencias.Location = new System.Drawing.Point(4, 25);
            this.tpPreferencias.Name = "tpPreferencias";
            this.tpPreferencias.Padding = new System.Windows.Forms.Padding(3);
            this.tpPreferencias.Size = new System.Drawing.Size(1166, 492);
            this.tpPreferencias.TabIndex = 1;
            this.tpPreferencias.Text = "Preferencias";
            // 
            // lbCalificacion
            // 
            this.lbCalificacion.AutoSize = true;
            this.lbCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalificacion.Location = new System.Drawing.Point(834, 322);
            this.lbCalificacion.Name = "lbCalificacion";
            this.lbCalificacion.Size = new System.Drawing.Size(0, 39);
            this.lbCalificacion.TabIndex = 7;
            // 
            // tbsatisfaccion
            // 
            this.tbsatisfaccion.Location = new System.Drawing.Point(543, 333);
            this.tbsatisfaccion.Name = "tbsatisfaccion";
            this.tbsatisfaccion.Size = new System.Drawing.Size(285, 56);
            this.tbsatisfaccion.TabIndex = 6;
            this.tbsatisfaccion.Scroll += new System.EventHandler(this.tbsatisfaccion_Scroll);
            // 
            // lbSatisfaccion
            // 
            this.lbSatisfaccion.AutoSize = true;
            this.lbSatisfaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSatisfaccion.Location = new System.Drawing.Point(486, 265);
            this.lbSatisfaccion.Name = "lbSatisfaccion";
            this.lbSatisfaccion.Size = new System.Drawing.Size(426, 39);
            this.lbSatisfaccion.TabIndex = 5;
            this.lbSatisfaccion.Text = "Satisfacción con el servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "País de residencia";
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Items.AddRange(new object[] {
            "Japón",
            "Brasil",
            "Canadá",
            "Egipto",
            "Alemania",
            "Australia",
            "México",
            "Sudáfrica",
            "España",
            "India"});
            this.cbPais.Location = new System.Drawing.Point(559, 193);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(121, 24);
            this.cbPais.TabIndex = 3;
            // 
            // lbHobbies
            // 
            this.lbHobbies.AutoSize = true;
            this.lbHobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHobbies.Location = new System.Drawing.Point(111, 127);
            this.lbHobbies.Name = "lbHobbies";
            this.lbHobbies.Size = new System.Drawing.Size(143, 39);
            this.lbHobbies.TabIndex = 2;
            this.lbHobbies.Text = "Hobbies";
            // 
            // ckbHobbies
            // 
            this.ckbHobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHobbies.FormattingEnabled = true;
            this.ckbHobbies.Items.AddRange(new object[] {
            "Lectura",
            "Deportes",
            "Cine",
            "Música",
            "Viajar",
            "Cocina",
            "Fotografía",
            "Videojuegos"});
            this.ckbHobbies.Location = new System.Drawing.Point(63, 169);
            this.ckbHobbies.Name = "ckbHobbies";
            this.ckbHobbies.Size = new System.Drawing.Size(244, 204);
            this.ckbHobbies.TabIndex = 1;
            // 
            // ckSuscribirse
            // 
            this.ckSuscribirse.AutoSize = true;
            this.ckSuscribirse.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckSuscribirse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckSuscribirse.Location = new System.Drawing.Point(63, 54);
            this.ckSuscribirse.Name = "ckSuscribirse";
            this.ckSuscribirse.Size = new System.Drawing.Size(392, 43);
            this.ckSuscribirse.TabIndex = 0;
            this.ckSuscribirse.Text = "¿Suscribirse al boletín?";
            this.ckSuscribirse.UseVisualStyleBackColor = true;
            // 
            // tpVisualización
            // 
            this.tpVisualización.BackColor = System.Drawing.Color.DarkGray;
            this.tpVisualización.Controls.Add(this.lbFechaHora);
            this.tpVisualización.Controls.Add(this.pictureBox1);
            this.tpVisualización.Location = new System.Drawing.Point(4, 25);
            this.tpVisualización.Name = "tpVisualización";
            this.tpVisualización.Size = new System.Drawing.Size(1166, 492);
            this.tpVisualización.TabIndex = 2;
            this.tpVisualización.Text = "Visualización";
            // 
            // lbFechaHora
            // 
            this.lbFechaHora.AutoSize = true;
            this.lbFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaHora.Location = new System.Drawing.Point(633, 100);
            this.lbFechaHora.Name = "lbFechaHora";
            this.lbFechaHora.Size = new System.Drawing.Size(275, 58);
            this.lbFechaHora.TabIndex = 1;
            this.lbFechaHora.Text = "HH/MM/SS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestión_Avanzada_de_Información_Persona.Properties.Resources.R;
            this.pictureBox1.Location = new System.Drawing.Point(43, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 423);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
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
            ((System.ComponentModel.ISupportInitialize)(this.numberEdad)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpPreferencias.ResumeLayout(false);
            this.tpPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbsatisfaccion)).EndInit();
            this.tpVisualización.ResumeLayout(false);
            this.tpVisualización.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numberEdad;
        private System.Windows.Forms.Label lbFechaNac;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.CheckBox ckSuscribirse;
        private System.Windows.Forms.Label lbHobbies;
        private System.Windows.Forms.CheckedListBox ckbHobbies;
        private System.Windows.Forms.Label lbCalificacion;
        private System.Windows.Forms.TrackBar tbsatisfaccion;
        private System.Windows.Forms.Label lbSatisfaccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Label lbFechaHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


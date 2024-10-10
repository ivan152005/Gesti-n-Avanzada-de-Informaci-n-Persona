using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_Avanzada_de_Información_Persona
{
    public partial class GestionAvanzadaInformacionPersonal : Form
    {
        public GestionAvanzadaInformacionPersonal()
        {
            InitializeComponent();


            toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btLimpiar, "Sirve para limpiar los atributos");
            toolTip1.SetToolTip(btGuardar, "Sirve para guardar los atributos");
            toolTip1.SetToolTip(btSalir, "Cierra el formulario");
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (ckSuscribirse.Checked)
            {
                if (!string.IsNullOrWhiteSpace(tbNombre.Text) &&
                    !string.IsNullOrWhiteSpace(tbDireccion.Text) &&
                    !string.IsNullOrWhiteSpace(tbCorreo.Text) &&
                    ckbHobbies.CheckedItems.Count > 0 &&
                    cbPais.SelectedIndex != -1 &&
                    numberEdad.Value > 0 &&
                    rbFemenino.Checked || rbMasculino.Checked || rbOtro.Checked)
                {
                    Persona persona = new Persona(tbNombre.Text, tbDireccion.Text, tbCorreo.Text,
                        rbMasculino.Checked ? "Masculino" : rbOtro.Checked ? "Otro" : "Femenino",
                        monthCalendar1.SelectionStart, (int)numberEdad.Value, new ArrayList(),
                        cbPais.SelectedItem.ToString(), tbsatisfaccion.Value);

                    //añado al arraylist
                    foreach (var item in ckbHobbies.CheckedItems)
                    {
                        persona.hobbies.Add(item.ToString());
                    }

                    limpiar();

                    DialogResult rs = MessageBox.Show("¿Quiere ver sus datos?",
                        "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        MessageBox.Show(persona.ToString());
                    }
                }
                else
                {
                    DialogResult rs = MessageBox.Show("Tiene que completar todo el formulario",
                        "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                DialogResult rs = MessageBox.Show("Tiene que hacer click en suscribirse",
                        "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        public void limpiar()
        {
            tbNombre.Clear();
            tbDireccion.Clear();
            tbCorreo.Clear();
            monthCalendar1.SetDate(DateTime.Now);
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            rbOtro.Checked = false;
            numberEdad.Value = 0;
            ckSuscribirse.Checked = false;

            //para marcar todos a falso
            for (int i = 0; i < ckbHobbies.Items.Count; i++)
            {
                ckbHobbies.SetItemChecked(i, false);
            }

            cbPais.SelectedIndex = 0;
            tbsatisfaccion.Value = 0;
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbFechaHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btLimpiar, "Sirve para limpiar los atributos");
            toolTip1.SetToolTip(btGuardar, "Sirve para guardar los atributos");
        }

        private void tbsatisfaccion_Scroll(object sender, EventArgs e)
        {
            lbCalificacion.Text = tbsatisfaccion.Value.ToString();
        }
    }

    public class Persona
    {
        public string nombre;
        public string direccion;
        public string correo;
        public string sexo;
        public DateTime fechaNacimiento;
        public int edad;
        public ArrayList hobbies;
        public string paisResidencia;
        public int satisfaccion;

        public Persona(string nombre, string direccion, string correo, string sexo, DateTime fechaNacimiento, int edad, ArrayList hobbies, string paisResidencia, int satisfaccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.correo = correo;
            this.sexo = sexo;
            this.fechaNacimiento = fechaNacimiento;
            this.edad = edad;
            this.hobbies = hobbies;
            this.paisResidencia = paisResidencia;
            this.satisfaccion = satisfaccion;
        }

        public override string ToString()
        {
            string hobbiesString= "";
            for (int i = 0; i < hobbies.Count; i++)
            {
                hobbiesString = hobbiesString + hobbies[i].ToString();
                if (i < hobbies.Count-1)
                {
                    hobbiesString += ", ";
                }
                else
                {
                    //para no confundir con el siguiente atributo
                    hobbiesString += "  ";
                }
            }

            return $"Nombre: {nombre}, Dirección: {direccion}, Correo: {correo}, Sexo: {sexo}, " +
               $"Fecha de Nacimiento: {fechaNacimiento.ToShortDateString()}, Edad: {edad}, " +
               $"Hobbies: {hobbiesString}, País de Residencia: {paisResidencia}, Satisfacción: {satisfaccion}";
        }
    }
}

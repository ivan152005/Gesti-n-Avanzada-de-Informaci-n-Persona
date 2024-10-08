using System;
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
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboEstadoCivil.Items.Add("Soltero/a");
            cboEstadoCivil.Items.Add("Casado/a");
            cboEstadoCivil.Items.Add("Viudo/a");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            string genero;
            if (rbtMasculino.Checked)
                genero = "Masculino";
            else if (rbtFemenino.Checked)
                genero = "Femenino";
            else
                genero = "Otro";
            String EstadoCivil = cboEstadoCivil.SelectedItem.ToString();

            MessageBox.Show("Su nombre es " + nombre + " nacio el " + fecha + " se identifica con el genero " + genero + " y su estado civil es " + EstadoCivil);
        }

        
    }
}
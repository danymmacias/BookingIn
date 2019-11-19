using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentalsof
{
    public partial class Expediente : Form
    {
        public Expediente()
        {
            InitializeComponent();
        }
        conexion sql = new conexion();
        validacion validacion = new validacion();
        private void Expediente_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {

                MessageBox.Show("ERROR. Ingresar nombre de paciente ");

            }
            else
            {
                if (textBox1.Text != "")
                {

                    dgvexpediente.DataSource = sql.Buscarexpediente(textBox1.Text);
                }
                else
                {
                    dgvexpediente.DataSource = sql.MostrarDatos();

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }
    }
}

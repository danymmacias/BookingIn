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
    public partial class Clientes_nuevos : Form
    {
        validacion validacion = new validacion();
        conexion conex = new conexion();

        public Clientes_nuevos()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clientes_nuevos_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_edad.Text) || string.IsNullOrEmpty(txt_telefono.Text) || string.IsNullOrEmpty(txt_direccion.Text) || string.IsNullOrEmpty(txt_estatura.Text) || string.IsNullOrEmpty(txt_peso.Text) || string.IsNullOrEmpty(cmb_civil.Text) || string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_correo.Text) || string.IsNullOrEmpty(txt_descripcion.Text) || (rdb_femenino.Checked == false && rdb_masculino.Checked == false))
            {
                MessageBox.Show("Llenar campos vacíos");
            }
            else
            {
                if (conex.personaRegistrada(txt_nombre.Text) == 0)
                {
                    MessageBox.Show(conex.insertarCliente(txt_nombre.Text, dateTime_fecha.Text, Convert.ToInt32(txt_edad.Text), lblsexo.Text, txt_telefono.Text, txt_direccion.Text, dateTime_fecha_nacimiento.Text, cmb_civil.Text, Convert.ToSingle(txt_estatura.Text), Convert.ToSingle(txt_peso.Text), txt_ocupacion.Text, txt_correo.Text, txt_descripcion.Text));
                    txt_nombre.Clear();
                    txt_telefono.Clear();
                    rdb_femenino.Checked = false;
                    rdb_masculino.Checked = false;
                    txt_edad.Clear();
                    txt_ocupacion.Clear();
                    txt_correo.Clear();
                    txt_direccion.Clear();
                    txt_estatura.Clear();
                    txt_peso.Clear();
                    cmb_civil.SelectedIndex = -1;
                    txt_descripcion.Clear();
                    //dateTime_fecha_nacimiento.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Ya existe");
                }
            }
        }

        private void rdb_femenino_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_femenino.Checked == true)
            {
                lblsexo.Text = "F";
            }
            else
            {
                lblsexo.Text = "";
            }
        }

        private void rdb_masculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_masculino.Checked == true)
            {
                lblsexo.Text = "M";
            }
            else
            {
                lblsexo.Text = "";
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
            txt_nombre.Text.ToString().ToUpper();
        }

        private void txt_edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txt_estatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txt_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txt_ocupacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        private void txt_correo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        private void lblsexo_Click(object sender, EventArgs e)
        {

        }
    }
}

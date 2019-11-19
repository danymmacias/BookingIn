using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dentalsof
{
    public partial class Clientes : Form
    {
        validacion validacion = new validacion();
        private SqlConnection conn =  new SqlConnection("Data source = DESKTOP-AJ6PA22; Initial catalog = DENTALSOFT; Integrated security = true");
        SqlCommand cmd = null;
        conexion conex = new conexion();
          
        public Clientes()
        {   
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
        
           
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string tratamiento;
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (cmb_diabetes.SelectedIndex == -1 || cmb_presion.SelectedIndex == -1 || cmb_hemofilia.SelectedIndex == -1 || cmb_epilepsia.SelectedIndex == -1 || cmb_hepatitis.SelectedIndex == -1 || cmb_hemorragia.SelectedIndex == -1 || cmb_operaciones.SelectedIndex == -1 || cmb_h1.SelectedIndex == -1 || cmb_h2.SelectedIndex == -1 || cmb_h3.SelectedIndex == -1 || cmb_h4.SelectedIndex == -1 || cmb_h5.SelectedIndex == -1 || cmb_n1.SelectedIndex == -1 || cmb_n2.SelectedIndex == -1 || cmb_n3.SelectedIndex == -1 || cmb_n4.SelectedIndex == -1 || cmb_n5.SelectedIndex == -1 || cmb_n6.SelectedIndex == -1 || cmb_1.SelectedIndex == -1 || cmb_2.SelectedIndex == -1 || cmb_3.SelectedIndex == -1)
            {
                MessageBox.Show("Llenar campos.");
            }
            else
            {
                MessageBox.Show(conex.guardarHistorial(txt_nom.Text, (Convert.ToInt32(txt_id.Text)), cmb_diabetes.Text, cmb_presion.Text, cmb_hemofilia.Text, cmb_epilepsia.Text, cmb_hepatitis.Text, cmb_hemorragia.Text, cmb_operaciones.Text, cmb_1.Text, cmb_2.Text, cmb_3.Text, txt_tp.Text, cmb_h1.Text, cmb_h2.Text, cmb_h3.Text, cmb_h4.Text, cmb_h5.Text, cmb_n1.Text, cmb_n2.Text, Convert.ToInt32(txt_veces.Text), cmb_n6.Text, cmb_n3.Text, cmb_n4.Text, cmb_n5.Text, txt_examen.Text, txt_motivos.Text, txt_d1.Text, txt_d2.Text, txt_d4.Text, txt_d7.Text, txt_d3.Text, txt_d6.Text, txt_d5.Text, txt1.Text, txt2.Text, txt_rx1.Text, txt_rx2.Text, txt_rx3.Text, txt_rx4.Text, txt_rx5.Text, txt_rx6.Text, txt_rx7.Text));


                cmb_diabetes.SelectedIndex = -1;
                cmb_presion.SelectedIndex = -1;
                cmb_hemofilia.SelectedIndex = -1;
                cmb_epilepsia.SelectedIndex = -1;
                cmb_hepatitis.SelectedIndex = -1;
                cmb_hemorragia.SelectedIndex = -1;
                cmb_operaciones.SelectedIndex = -1;
                cmb_h1.SelectedIndex = -1;
                cmb_h2.SelectedIndex = -1;
                cmb_h3.SelectedIndex = -1;
                cmb_h4.SelectedIndex = -1;
                cmb_h5.SelectedIndex = -1;
                cmb_n1.SelectedIndex = -1;
                cmb_n2.SelectedIndex = -1;
                cmb_n3.SelectedIndex = -1;
                cmb_n4.SelectedIndex = -1;
                cmb_n5.SelectedIndex = -1;
                cmb_n6.SelectedIndex = -1;
                cmb_1.SelectedIndex = -1;
                cmb_2.SelectedIndex = -1;
                cmb_3.SelectedIndex = -1;
                txt_veces.Clear();
                txt_examen.Clear();
                txt_motivos.Clear();
            }

            cmd = new SqlCommand("INSERT from costos clave_paciente ='" + txt_id.Text + "', nom_paciente='" + txt_nom.Text + "'", conn);
            
        }

        private void txt_veces_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void cmb_diabetes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_diabetes.Text == "SI")
            {
                txt_d1.ReadOnly = false;
                txt_rx1.ReadOnly = false;
            }
            else
            {
                txt_d1.Clear();
                txt_rx1.Clear();
                txt_d1.ReadOnly = true;
                txt_rx1.ReadOnly = true;
            }
        }

        private void cmb_presion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_presion.Text == "SI")
            {
                txt_d2.ReadOnly = false;
                txt_rx2.ReadOnly = false;
            }
            else
            {
                txt_d2.Clear();
                txt_rx2.Clear();
                txt_d2.ReadOnly = true;
                txt_rx2.ReadOnly = true;
            }
        }

        private void cmb_hemofilia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_hemofilia.Text == "SI")
            {
                txt_d3.ReadOnly = false;
                txt_rx3.ReadOnly = false;
            }
            else
            {
                txt_d3.Clear();
                txt_rx3.Clear();
                txt_d3.ReadOnly = true;
                txt_rx3.ReadOnly = true;
            }
        }

        private void cmb_epilepsia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_epilepsia.Text == "SI")
            {
                txt_d4.ReadOnly = false;
                txt_rx4.ReadOnly = false;
            }
            else
            {
                txt_d4.Clear();
                txt_rx4.Clear();
                txt_d4.ReadOnly = true;
                txt_rx4.ReadOnly = true;
            }
        }

        private void cmb_hepatitis_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_hepatitis.Text == "SI")
            {
                txt_d5.ReadOnly = false;
                txt_rx5.ReadOnly = false;
            }
            else
            {
                txt_d5.Clear();
                txt_rx5.Clear();
                txt_d5.ReadOnly = true;
                txt_rx5.ReadOnly = true;
            }
        }

        private void cmb_hemorragia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_hemorragia.Text == "SI")
            {
                txt_d6.ReadOnly = false;
                txt_rx6.ReadOnly = false;
            }
            else
            {
                txt_d6.Clear();
                txt_rx6.Clear();
                txt_d6.ReadOnly = true;
                txt_rx6.ReadOnly = true;
            }
        }

        private void cmb_operaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_operaciones.Text == "SI")
            {
                txt_d7.ReadOnly = false;
                txt_rx7.ReadOnly = false;
            }
            else
            {
                txt_d7.Clear();
                txt_rx7.Clear();
                txt_d7.ReadOnly = true;
                txt_rx7.ReadOnly = true;
            }
        }

        private void cmb_1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_1.Text == "SI")
            {
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
            }
            else
            {
                txt1.Clear();
                txt2.Clear();
                txt1.ReadOnly = true;
                txt2.ReadOnly = true;
            }
        }

        private void cmb_3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_3.Text == "SI")
            {
                txt_tp.ReadOnly = false;
            }
            else
            {
                txt_tp.Clear();
                txt_tp.ReadOnly = true;
            }
        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

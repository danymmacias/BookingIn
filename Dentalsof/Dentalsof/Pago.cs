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
    public partial class Pago : Form
    {
        public Pago()
        {
            InitializeComponent();
        }
        //conexion sql = new conexion();
        conexion conex = new conexion();
        validacion validacion = new validacion();
        //private SqlConnection conn = new SqlConnection("Data source = DESKTOP-AJ6PA22; Initial catalog = DENTALSOFT; Integrated security = true");
        //SqlDataReader dr = null;
        //SqlCommand cmd = null;

        //public string clave, clave_p, costo_ex;

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void Pago_Load(object sender, EventArgs e)
        {
     
            
      
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conex.insertarCosto(lbl_nom.Text, lbl_nomtratamiento.Text, txt_desc.Text, txt_extra.Text, lbl_total.Text));
            
        }

        private void txt_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_extra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            double total = 0;

            total = Convert.ToDouble(txt_costo.Text) + Convert.ToDouble(txt_extra.Text);
            lbl_total.Text = total.ToString();
            btn_guardar.Enabled = true;
        }

        private void label8_Click (object sender, EventArgs e)
        {

        }

    }
}

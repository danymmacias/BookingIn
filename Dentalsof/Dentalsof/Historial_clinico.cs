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
    public partial class Historial_clinico : Form
    {
        conexion conex = new conexion();
        validacion validacion = new validacion();
        Bitmap bmp;

        public Historial_clinico()
        {
            InitializeComponent();
            conex.seleccionar(cmb_buscar);
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_buscar_SelectedIndexChanged(object sender, EventArgs e)
        {

            txt_nombre.ReadOnly = true;
            txt_edad.ReadOnly = true;
            cmb_sexo.Enabled = false;
            txt_telefono.ReadOnly = true;
            txt_dire.ReadOnly = true;
            dt_fecha_n.Enabled = false;
            cmb_civil.Enabled= false;
            txt_estatura.ReadOnly = true;
            txt_peso.ReadOnly = true;
            txt_ocupacion.ReadOnly = true;
            txt_correo.ReadOnly = true;
            txt_desc.ReadOnly = true;

            cmb_diabetes.SelectedIndex = -1;
            cmb_presion.SelectedIndex = -1;
            cmb_hemofilia.SelectedIndex = -1;
            cmb_epilepsia.SelectedIndex = -1;
            cmb_hepatitis.SelectedIndex = -1;
            cmb_hemorragias.SelectedIndex = -1;
            cmb_operaciones.SelectedIndex = -1;

            cmb_n1.SelectedIndex = -1;
            cmb_n2.SelectedIndex = -1;
            cmb_n3.SelectedIndex = -1;
            cmb_n4.SelectedIndex = -1;
            cmb_n5.SelectedIndex = -1;
            cmb_n6.SelectedIndex = -1;

            cmb_h1.SelectedIndex = -1;
            cmb_h2.SelectedIndex = -1;
            cmb_h3.SelectedIndex = -1;
            cmb_h4.SelectedIndex = -1;
            cmb_h5.SelectedIndex = -1;

            cmb_1.SelectedIndex = -1;
            cmb_2.SelectedIndex = -1;
            cmb_3.SelectedIndex = -1;

            txt_examen.Clear();
            txt_motivos.Clear();

            txt1.Clear();
            txt2.Clear();
            txt_tp.Clear();
            txt_veces.Clear();



            if (cmb_buscar.SelectedIndex > 0)
            {
                btn_modificar.Enabled = true;
                btn_imprimir.Enabled = true;

                if (conex.historial_Registrado2(cmb_buscar.Text) == 0)
                {
                    string[] resultado = conex.cargar_DatosGenerales(cmb_buscar.Text);
                    //DATOS GENERALES
                    txt_ID_paciente.Text = resultado[0];
                    txt_nombre.Text = resultado[1];
                    txt_edad.Text = resultado[2];
                    cmb_sexo.Text = resultado[3];
                    txt_dire.Text = resultado[4];
                    txt_telefono.Text = resultado[5];
                    txt_fecha_registro.Text = resultado[6];
                    cmb_civil.Text = resultado[7];
                    dt_fecha_n.Text = resultado[8];
                    txt_estatura.Text = resultado[9];
                    txt_peso.Text = resultado[10];
                    txt_ocupacion.Text = resultado[11];
                    txt_correo.Text = resultado[12];
                    txt_desc.Text = resultado[13];
                }
                else
                {
                    //DATOS GENERALES
                    string[] resultado = conex.cargar_DatosGenerales(cmb_buscar.Text);
                    txt_ID_paciente.Text = resultado[0];
                    txt_nombre.Text = resultado[1];
                    txt_edad.Text = resultado[2];
                    cmb_sexo.Text = resultado[3];
                    txt_dire.Text = resultado[4];
                    txt_telefono.Text = resultado[5];
                    txt_fecha_registro.Text = resultado[6];
                    cmb_civil.Text = resultado[7];
                    dt_fecha_n.Text = resultado[8];
                    txt_estatura.Text = resultado[9];
                    txt_peso.Text = resultado[10];
                    txt_ocupacion.Text = resultado[11];
                    txt_correo.Text = resultado[12];
                    txt_desc.Text = resultado[13];
                    string[] resultados = conex.cargar_historialclinico(cmb_buscar.Text);
                    //HISTORIAL
                    cmb_diabetes.Text = resultados[0];
                    cmb_presion.Text = resultados[1];
                    cmb_hemofilia.Text = resultados[2];
                    cmb_epilepsia.Text = resultados[3];
                    cmb_hepatitis.Text = resultados[4];
                    cmb_hemorragias.Text = resultados[5];
                    cmb_operaciones.Text = resultados[6];
                    cmb_1.Text = resultados[7];
                    cmb_2.Text = resultados[8];
                    cmb_3.Text = resultados[9];
                    txt_tp.Text = resultados[10];
                    cmb_h1.Text = resultados[11];
                    cmb_h2.Text = resultados[12];
                    cmb_h3.Text = resultados[13];
                    cmb_h4.Text = resultados[14];
                    cmb_h5.Text = resultados[15];
                    cmb_n1.Text = resultados[16];
                    cmb_n2.Text = resultados[17];
                    txt_veces.Text = resultados[18];
                    cmb_n6.Text = resultados[19];
                    cmb_n3.Text = resultados[20];
                    cmb_n4.Text = resultados[21];
                    cmb_n5.Text = resultados[22];
                    txt_examen.Text = resultados[23];
                    txt_motivos.Text = resultados[24];
                    txt_d1.Text = resultados[25];
                    txt_d2.Text = resultados[26];
                    txt_d4.Text = resultados[27];
                    txt_d7.Text = resultados[28];
                    txt_d3.Text = resultados[29];
                    txt_d6.Text = resultados[30];
                    txt_d5.Text = resultados[31];
                    txt1.Text = resultados[32];
                    txt2.Text = resultados[33];
                    txt_rx1.Text = resultados[34];
                    txt_rx2.Text = resultados[35];
                    txt_rx3.Text = resultados[36];
                    txt_rx4.Text = resultados[37];
                    txt_rx5.Text = resultados[38];
                    txt_rx6.Text = resultados[39];
                    txt_rx7.Text = resultados[40];
                }
            }
            else 
            {
                btn_modificar.Enabled = false;
                btn_guardar.Enabled = false;
                btn_imprimir.Enabled = false;

                txt_ID_paciente.Clear();
                txt_nombre.Clear();
                txt_fecha_registro.Clear();
                txt_edad.Clear();
                cmb_sexo.SelectedIndex = -1;
                txt_telefono.Clear();
                txt_dire.Clear();
                dt_fecha_n.ResetText();
                cmb_civil.SelectedIndex = -1;
                txt_estatura.Clear();
                txt_peso.Clear();
                txt_ocupacion.Clear();
                txt_correo.Clear();
                txt_desc.Clear();

                cmb_diabetes.Enabled = false;
                cmb_presion.Enabled = false;
                cmb_hemofilia.Enabled = false;
                cmb_epilepsia.Enabled = false;
                cmb_hepatitis.Enabled = false;
                cmb_hemorragias.Enabled = false;
                cmb_operaciones.Enabled = false;

                cmb_n1.Enabled = false;
                cmb_n2.Enabled = false;
                cmb_n3.Enabled = false;
                cmb_n4.Enabled = false;
                cmb_n5.Enabled = false;
                cmb_n6.Enabled = false;

                cmb_h1.Enabled = false;
                cmb_h2.Enabled = false;
                cmb_h3.Enabled = false;
                cmb_h4.Enabled = false;
                cmb_h5.Enabled = false;

                cmb_1.Enabled = false;
                cmb_2.Enabled = false;
                cmb_3.Enabled = false;

                txt_examen.ReadOnly = true;
                txt_motivos.ReadOnly = true;

                txt1.ReadOnly = true;
                txt2.ReadOnly = true;
                txt_tp.ReadOnly = true;
                txt_veces.ReadOnly = true;
                
                
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            btn_guardar.Enabled = true;
           
            if (cmb_buscar.SelectedIndex > 0)
            {
                if (conex.historial_Registrado2(cmb_buscar.Text) == 0)
                {
                    btn_guardar.Enabled = true;
                    btn_modificar.Enabled = true;

                    txt_edad.ReadOnly = false;
                    cmb_sexo.Enabled = true;
                    txt_telefono.ReadOnly = false;
                    txt_dire.ReadOnly = false;
                    dt_fecha_n.Enabled = true;
                    cmb_civil.Enabled = true;
                    txt_estatura.ReadOnly = false;
                    txt_peso.ReadOnly = false;
                    txt_ocupacion.ReadOnly = false;
                    txt_correo.ReadOnly = false;
                    txt_desc.ReadOnly = false;
                }
                else
                {
                    txt_edad.ReadOnly = false;
                    cmb_sexo.Enabled = true;
                    txt_telefono.ReadOnly = false;
                    txt_dire.ReadOnly = false;
                    dt_fecha_n.Enabled = true;
                    cmb_civil.Enabled = true;
                    txt_estatura.ReadOnly = false;
                    txt_peso.ReadOnly = false;
                    txt_ocupacion.ReadOnly = false;
                    txt_correo.ReadOnly = false;
                    txt_desc.ReadOnly = false;

                    cmb_diabetes.Enabled = true;
                    cmb_presion.Enabled = true;
                    cmb_hemofilia.Enabled = true;
                    cmb_epilepsia.Enabled = true;
                    cmb_hepatitis.Enabled = true;
                    cmb_hemorragias.Enabled = true;
                    cmb_operaciones.Enabled = true;

                    cmb_n1.Enabled = true;
                    cmb_n2.Enabled = true;
                    cmb_n3.Enabled = true;
                    cmb_n4.Enabled = true;
                    cmb_n5.Enabled = true;
                    cmb_n6.Enabled = true;

                    cmb_h1.Enabled = true;
                    cmb_h2.Enabled = true;
                    cmb_h3.Enabled = true;
                    cmb_h4.Enabled = true;
                    cmb_h5.Enabled = true;

                    cmb_1.Enabled = true;
                    cmb_2.Enabled = true;
                    cmb_3.Enabled = true;

                    txt_examen.ReadOnly = false;
                    txt_motivos.ReadOnly = false;

                    txt1.ReadOnly = false;
                    txt2.ReadOnly = false;
                    txt_tp.ReadOnly = false;
                    txt_veces.ReadOnly = false;
                }
     
            }
            //else
            //{
                //txt_nombre.ReadOnly = true;
                //txt_edad.ReadOnly = true;
                //cmb_sexo.Enabled = false;
                //txt_telefono.ReadOnly = true;
                //txt_dire.ReadOnly = true;
                //dt_fecha_n.Enabled = false;
                //txt_civil.ReadOnly = true;
                //txt_estatura.ReadOnly = true;
                //txt_peso.ReadOnly = true;
                //txt_ocupacion.ReadOnly = true;
                //txt_correo.ReadOnly = true;
                //txt_desc.ReadOnly = true;

                //cmb_diabetes.Enabled = false;
                //cmb_presion.Enabled = false;
                //cmb_hemofilia.Enabled = false;
                //cmb_epilepsia.Enabled = false;
                //cmb_hepatitis.Enabled = false;
                //cmb_hemorragias.Enabled = false;
                //cmb_operaciones.Enabled = false;

                //cmb_n1.Enabled = false;
                //cmb_n2.Enabled = false;
                //cmb_n3.Enabled = false;
                //cmb_n4.Enabled = false;
                //cmb_n5.Enabled = false;
                //cmb_n6.Enabled = false;

                //cmb_h1.Enabled = false;
                //cmb_h2.Enabled = false;
                //cmb_h3.Enabled = false;
                //cmb_h4.Enabled = false;
                //cmb_h5.Enabled = false;

                //cmb_1.Enabled = false;
                //cmb_2.Enabled = false;
                //cmb_3.Enabled = false;

                //txt_examen.ReadOnly = true;
                //txt_motivos.ReadOnly = true;

                //txt1.ReadOnly = true;
                //txt2.ReadOnly = true;
                //txt_tp.ReadOnly = true;

                //txt_veces.ReadOnly = true;
            //}
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_edad.Text) || string.IsNullOrEmpty(txt_telefono.Text) || string.IsNullOrEmpty(txt_dire.Text) || string.IsNullOrEmpty(txt_estatura.Text) || string.IsNullOrEmpty(txt_peso.Text) ||  string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_correo.Text) || string.IsNullOrEmpty(txt_desc.Text))
            {
                MessageBox.Show("Llenar campos vacíos");
            }
            else
            {
                if (conex.historial_Registrado2(cmb_buscar.Text) == 0)
                {

                    MessageBox.Show(conex.ActualizarDatosCliente(cmb_buscar.Text, Convert.ToInt32(txt_edad.Text), cmb_sexo.Text, txt_telefono.Text, txt_dire.Text, dt_fecha_n.Text, cmb_civil.Text, Convert.ToSingle(txt_estatura.Text), Convert.ToSingle(txt_peso.Text), txt_ocupacion.Text, txt_correo.Text, txt_desc.Text));

                    cmb_buscar.SelectedIndex = 0;
                    txt_nombre.Clear();
                    cmb_sexo.SelectedIndex = -1;
                    txt_edad.Clear();
                    txt_telefono.Clear();
                    txt_dire.Clear();
                    txt_estatura.Clear();
                    txt_peso.Clear();
                    cmb_civil.SelectedIndex = -1;
                    txt_ocupacion.Clear();
                    txt_correo.Clear();
                    txt_desc.Clear();
                    txt_fecha_registro.Clear();
                }
                else
                {
                    conex.ActualizarDatosCliente(cmb_buscar.Text, Convert.ToInt32(txt_edad.Text), cmb_sexo.Text, txt_telefono.Text, txt_dire.Text, dt_fecha_n.Text, cmb_civil.Text, Convert.ToSingle(txt_estatura.Text), Convert.ToSingle(txt_peso.Text), txt_ocupacion.Text, txt_correo.Text, txt_desc.Text);
                    MessageBox.Show(conex.ActualizarHistorial(cmb_buscar.Text, cmb_diabetes.Text, cmb_presion.Text, cmb_hemofilia.Text, cmb_epilepsia.Text, cmb_hepatitis.Text, cmb_hemorragias.Text, cmb_operaciones.Text, cmb_1.Text, cmb_2.Text, cmb_3.Text, txt_tp.Text, cmb_h1.Text, cmb_h2.Text, cmb_h3.Text, cmb_h4.Text, cmb_h5.Text, cmb_n1.Text, cmb_n2.Text, Convert.ToInt32(txt_veces.Text), cmb_n6.Text, cmb_n3.Text, cmb_n4.Text, cmb_n5.Text, txt_examen.Text, txt_motivos.Text, txt_d1.Text, txt_d2.Text, txt_d3.Text, txt_d4.Text, txt_d5.Text, txt_d6.Text, txt_d7.Text, txt1.Text, txt2.Text, txt_rx1.Text, txt_rx2.Text, txt_rx3.Text, txt_rx4.Text, txt_rx5.Text, txt_rx6.Text, txt_rx7.Text));

                    cmb_buscar.SelectedIndex = 0;
                    //txt_nombre.Clear();
                    //cmb_sexo.SelectedIndex = -1;
                    //txt_edad.Clear();
                    //txt_telefono.Clear();
                    //txt_dire.Clear();
                    //txt_estatura.Clear();
                    //txt_peso.Clear();
                    //cmb_civil.SelectedIndex = -1;
                    //txt_ocupacion.Clear();
                    //txt_correo.Clear();
                    //txt_desc.Clear();
                    //txt_fecha_registro.Clear();

                    //cmb_diabetes.SelectedIndex = -1;
                    //cmb_presion.SelectedIndex = -1;
                    //cmb_hemofilia.SelectedIndex = -1;
                    //cmb_epilepsia.SelectedIndex = -1;
                    //cmb_hepatitis.SelectedIndex = -1;
                    //cmb_hemorragias.SelectedIndex = -1;
                    //cmb_operaciones.SelectedIndex = -1;
                    //cmb_diabetes.Enabled = false;
                    //cmb_presion.Enabled = false;
                    //cmb_hemofilia.Enabled = false;
                    //cmb_epilepsia.Enabled = false;
                    //cmb_hepatitis.Enabled = false;
                    //cmb_hemorragias.Enabled = false;
                    //cmb_operaciones.Enabled = false;
                    //txt_d1.Clear();
                    //txt_d2.Clear();
                    //txt_d3.Clear();
                    //txt_d4.Clear();
                    //txt_d5.Clear();
                    //txt_d6.Clear();
                    //txt_d7.Clear();
                    //txt_rx1.Clear();
                    //txt_rx2.Clear();
                    //txt_rx3.Clear();
                    //txt_rx4.Clear();
                    //txt_rx5.Clear();
                    //txt_rx6.Clear();
                    //txt_rx7.Clear();
                    //cmb_n1.SelectedIndex = -1;
                    //cmb_n2.SelectedIndex = -1;
                    //cmb_n3.SelectedIndex = -1;
                    //cmb_n4.SelectedIndex = -1;
                    //cmb_n5.SelectedIndex = -1;
                    //cmb_n6.SelectedIndex = -1;
                    //cmb_n1.Enabled = false;
                    //cmb_n2.Enabled = false;
                    //cmb_n3.Enabled = false;
                    //cmb_n4.Enabled = false;
                    //cmb_n5.Enabled = false;
                    //cmb_n6.Enabled = false;
                    //cmb_h1.SelectedIndex = -1;
                    //cmb_h2.SelectedIndex = -1;
                    //cmb_h3.SelectedIndex = -1;
                    //cmb_h4.SelectedIndex = -1;
                    //cmb_h5.SelectedIndex = -1;
                    //cmb_h1.Enabled = false;
                    //cmb_h2.Enabled = false;
                    //cmb_h3.Enabled = false;
                    //cmb_h4.Enabled = false;
                    //cmb_h5.Enabled = false;
                    //txt_veces.Clear();
                    //txt1.Clear();
                    //txt2.Clear();
                    //txt_tp.Clear();
                    //txt_examen.Clear();
                    //txt_motivos.Clear();
                    //cmb_1.SelectedIndex = -1;
                    //cmb_2.SelectedIndex = -1;
                    //cmb_3.SelectedIndex = -1;
                    //cmb_1.Enabled = false;
                    //cmb_2.Enabled = false;
                    //cmb_3.Enabled = false;
                    //txt1.ReadOnly = true;
                    //txt1.ReadOnly = true;
                    //txt_tp.ReadOnly = true;
                }
            }

        }

        private void dt_fecha_n_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
                   
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txt_edad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_desc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        private void txt_veces_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void cmb_diabetes_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cmb_hemofilia_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cmb_epilepsia_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cmb_hepatitis_SelectedIndexChanged(object sender, EventArgs e)
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

        private void cmb_hemorragias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_hemorragias.Text == "SI")
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

        private void cmb_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_1.Text== "SI")
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

        private void cmb_3_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            {
                e.Graphics.DrawImage(bmp, 0, 0);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       
    }
}

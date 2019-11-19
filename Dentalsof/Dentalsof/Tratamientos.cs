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
    public partial class Tratamientos : Form
    {
        public Tratamientos()
        {
            InitializeComponent();
        }


        conexion sql = new conexion();
        validacion validacion = new validacion();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_Tratamientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow fila = dataGridView_Tratamientos.Rows[e.RowIndex];
            txtbclavet.Text = Convert.ToString(fila.Cells[0].Value);
            txtbnombret.Text = Convert.ToString(fila.Cells[1].Value);
            txtbcostot.Text = Convert.ToString(fila.Cells[2].Value);
        }

        private void Tratamientos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dENTALSOFTDataSet2.tratamientos' Puede moverla o quitarla según sea necesario.
            //this.tratamientosTableAdapter.Fill(this.DENTALSOFTDataSet5.tratamientos);
            // TODO: esta línea de código carga datos en la tabla 'dENTALSOFTDataSet.tratamientos' Puede moverla o quitarla según sea necesario.
            
           // this.tratamientosTableAdapter.Fill(this.dENTALSOFTDataSet1.tratamientos);
           // dataGridView_Tratamientos.DataSource = sql.MostrarDatos();
        }

        private bool ValidarCampos() {

            bool ok = true;

            if (txtbnombret.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtbnombret, "Favor de ingresar nombre");


            }if(txtbcostot.Text=="")
            {
            
            ok =false;
                errorProvider1.SetError(txtbcostot, "Favor de ingresar costo del tratamiento");
            } return ok;

        
        }

        private void BorrarLosMensajesError() {
            errorProvider1.SetError(txtbnombret, "");
            errorProvider1.SetError(txtbcostot, "");
        
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sql.insertarTratamiento(txtbnombret.Text, txtbcostot.Text));  
             
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (sql.EliminarTratamientos(txtbclavet.Text))
            {

                MessageBox.Show("Se han eliminado los datos");
                dataGridView_Tratamientos.DataSource = sql.MostrarDatos();

            }
            else MessageBox.Show("No se han podido eliminar los datos");
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (sql.ActualizarTratamientos(txtbclavet.Text, txtbnombret.Text, txtbcostot.Text))
            {

                MessageBox.Show("Datos actualizados");
                dataGridView_Tratamientos.DataSource = sql.MostrarDatos();

            }
            else MessageBox.Show("No se han podido actualizar los datos");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {

                dataGridView_Tratamientos.DataSource = sql.BuscarTratamientos(txtbuscar.Text);
            }
            else
            {
                dataGridView_Tratamientos.DataSource = sql.MostrarDatos();

            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtbclavet.Text = "";
            txtbcostot.Text = "";
            txtbnombret.Text = "";
            txtbuscar.Text = "";
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbclavet_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtbnombret_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        private void txtbcostot_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        private void dataGridView_Tratamientos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }



    }
}

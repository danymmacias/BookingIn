using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Dentalsof
{
    public partial class Citas : Form
    {
        
        conexion conex = new conexion();
        List<String> horasDisponibles = new List<String>();


        public Citas()
        {
            InitializeComponent();
            conex.seleccionar(cmb_cliente);
            conex.seleccionar_tratamiento(cmb_tratamientos);
            horasDisponibles = comboHoras();
          
        }

        private void btn_clientes_nuevos_Click(object sender, EventArgs e)
        {
            cmb_cliente.SelectedIndex = 0;
            cmb_hora.SelectedIndex = -1;
            cmb_tratamientos.SelectedIndex = 0;

            Clientes_nuevos clientes_nuevos = new Clientes_nuevos();
            clientes_nuevos.ShowDialog();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {

           
        }

        private void btn_reagendar_Click(object sender, EventArgs e)
        {
            if (cmb_cliente.SelectedIndex == 0 || cmb_tratamientos.SelectedIndex == 0 || cmb_hora.SelectedIndex == -1)
            {
                MessageBox.Show("Llenar campos vacíos.");
            }
            else
            {
                if (cmb_tratamientos.Text == "Consulta")
                {
                    if (conex.historial_Registrado(Convert.ToInt32(txt_ID.Text)) == 0)
                    {
                        Clientes clientes = new Clientes();
                        clientes.txt_id.Text = txt_ID.Text;
                        clientes.txt_nom.Text = cmb_cliente.Text;
                        clientes.tratamiento = cmb_tratamientos.Text;
                        clientes.ShowDialog();
                        string respuesta = conex.agendarCita(cmb_cliente.SelectedItem.ToString(), Convert.ToString(txt_tel.Text), dtpDia.Text, cmb_hora.SelectedItem.ToString(), cmb_tratamientos.Text , lbl_precio.Text);
                        MessageBox.Show(respuesta);
                    }
                    else
                    {
                        string respuesta = conex.agendarCita(cmb_cliente.SelectedItem.ToString(), Convert.ToString(txt_tel.Text), dtpDia.Text, cmb_hora.SelectedItem.ToString(), cmb_tratamientos.SelectedItem.ToString(),lbl_precio.Text);
                        MessageBox.Show(respuesta);
                    }
                }
                else
                {
                    string respuesta = conex.agendarCita(cmb_cliente.SelectedItem.ToString(), Convert.ToString(txt_tel.Text), dtpDia.Text, cmb_hora.SelectedItem.ToString(), cmb_tratamientos.SelectedItem.ToString(), lbl_precio.Text);
                    MessageBox.Show(respuesta);
                }
                cmb_cliente.SelectedIndex = 0;
                cmb_tratamientos.SelectedIndex = 0;
                cmb_hora.SelectedIndex = -1;
                dtpDia.Value = DateTime.Now;
            }    
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Citas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dENTALSOFTDataSet3.agenda' Puede moverla o quitarla según sea necesario.
            //this.agendaTableAdapter.Fill(this.dENTALSOFTDataSet3.agenda);
            
            //var pacientes = new List<String>();
            //var tratamientos = new List<String>();
            var dias = new List<String>();
            //pacientes = conex.obtenerNombresClientes();
            //tratamientos = conex.obtenerTratamientos();
            
            //BindingSource bs = new BindingSource();
            //cmb_cliente.DataSource = pacientes;
            //cmb_tratamientos.DataSource = tratamientos;
            dias = conex.obtenerHoras(DateTime.Today.ToShortDateString());
            foreach(String dia in dias){
                cmb_hora.Items.Remove(dia);
            }
        }

        private void cmb_tratamientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tratamientos.SelectedIndex == 0)
            {
                btn_reagendar.Enabled = false;
            }
            else 
            {
                btn_reagendar.Enabled = true;
            }
            if (cmb_tratamientos.SelectedIndex > 0)
            {
                string[] resultado = conex.cargar_costo_tratamiento(cmb_tratamientos.Text);
                lbl_precio.Text = resultado[0];
            }
            else
            {
                lbl_precio.Text = "";
            }
        }

        private void txt_tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_cliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_cliente.SelectedIndex > 0)
            {
                string[] resultado = conex.cargar_info(cmb_cliente.Text);
                txt_ID.Text = resultado[0];
                txt_tel.Text = resultado[1];
                //conexion.clave_pacienteSeleccionado = txt_ID.Text;
            }
            else
            {
                txt_ID.Clear();
                txt_tel.Clear();
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            //var pacientes = new List<String>();
            var tratamientos = new List<String>();
            //pacientes = conex.obtenerNombresClientes();
            tratamientos = conex.obtenerTratamientos();
            BindingSource bs = new BindingSource();
            //cmb_cliente.DataSource = pacientes;
            cmb_tratamientos.DataSource = tratamientos;
            string[] resultado = conex.cargar_info(cmb_cliente.Text);
            txt_ID.Text = resultado[0];
            txt_tel.Text = resultado[1];
            
        }

        private void cmb_hora_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(cmb_hora.SelectedItem.ToString());
            //MessageBox.Show(cmb_hora.SelectedItem.ToString());
        }

        private void dtpDia_StyleChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }



        private void cargarFechas()
        {
            cmb_hora.Items.Clear();
            foreach (String dia in horasDisponibles)
            {
                cmb_hora.Items.Add(dia);
            }
        }

        private List<String> comboHoras()
        {
            var comboHoras = new List<String>();
            for (int i = 0; i < cmb_hora.Items.Count; i++)
            {
                comboHoras.Add(cmb_hora.GetItemText(cmb_hora.Items[i]));
            }
            return comboHoras;
        }

        private void dtpDia_ValueChanged(object sender, EventArgs e)
        {
            cargarFechas();
            var dias = new List<String>();
            dias = conex.obtenerHoras(dtpDia.Value.ToShortDateString());
            foreach (String dia in dias)
            {
                cmb_hora.Items.Remove(dia);
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Clientes clientes= new Clientes();
            clientes.ShowDialog();
        }

    }
}

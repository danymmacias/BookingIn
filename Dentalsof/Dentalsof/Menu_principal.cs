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
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }
        conexion conex = new conexion();
        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Citas citas = new Citas();
            citas.ShowDialog();
            
        }

        private void tratamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tratamientos tratamientos = new Tratamientos();
            tratamientos.ShowDialog();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var agenda = conex.obtenerCitas(calendario.SelectionRange.Start.ToShortDateString());
            if (agenda.Count == 0)
            {
                MessageBox.Show("No hay citas para este dia");
                dataGridView1.DataSource = null;
            }
            else
            {
                dataGridView1.DataSource = agenda;
                for (int i = 0; i < agenda.Count; i++)
                {
                    dataGridView1[0, i].Value = agenda[i].paciente;
                    dataGridView1[1, i].Value = agenda[i].telefono;
                    dataGridView1[2, i].Value = agenda[i].dia;
                    dataGridView1[3, i].Value = agenda[i].hora;
                    dataGridView1[4, i].Value = agenda[i].tratamiento;
                    dataGridView1[5, i].Value = agenda[i].cost;

                }

            }
        }

        private void costosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Costos costos = new Costos();
            costos.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historial_clinico hist = new Historial_clinico();
            hist.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void expedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expediente exp = new Expediente();
            exp.ShowDialog();
        }
        //Parte de expdiente del menu principal
        //Expediente exp = new Expediente();
        //   exp.ShowDialog();
        private void btn_pago_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var agenda = conex.obtenerCitas(calendario.SelectionRange.Start.ToShortDateString());
            if (agenda.Count == 0)
            {
                MessageBox.Show("No hay registro.");
            }
            else 
            {

                Pago pago = new Pago();
                pago.lbl_nom.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                pago.lbl_nomtratamiento.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                pago.txt_costo.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                pago.ShowDialog();
            }
        }
    }
}

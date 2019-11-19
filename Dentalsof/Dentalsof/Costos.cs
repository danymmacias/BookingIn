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
    public partial class Costos : Form
    {
        conexion sql = new conexion();

        conexion conex = new conexion();

        public Costos()
        {
            InitializeComponent();
        }
        
        validacion validacion = new validacion();

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Costos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dENTALSOFTDataSet2.costos' Puede moverla o quitarla según sea necesario.
           // this.costosTableAdapter.Fill(this.dENTALSOFTDataSet.costos);
            // TODO: esta línea de código carga datos en la tabla 'dENTALSOFTDataSet2.costos' Puede moverla o quitarla según sea necesario.
            //this.costosTableAdapter.Fill(this.dENTALSOFTDataSet.costos);

        }

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            if (txt_buscar_p.Text != "")
            {

                dataGridView_Costos.DataSource = sql.Buscarcosto(txt_buscar_p.Text);
            }
            else
            {
                dataGridView_Costos.DataSource = sql.MostrarDatosCosto();

            }
        }

        private void dataGridView_Costos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

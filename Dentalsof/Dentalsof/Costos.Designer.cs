namespace Dentalsof
{
    partial class Costos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Costos));
            this.dentalsoftDataSet4 = new Dentalsof.DENTALSOFTDataSet4();
            this.dataGridView_Costos = new System.Windows.Forms.DataGridView();
            this.clavecostosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nompacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clavetratamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomtratamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adeudopacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonadopacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoextraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscar_p = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dentalsoftDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Costos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dentalsoftDataSet4
            // 
            this.dentalsoftDataSet4.DataSetName = "DENTALSOFTDataSet";
            this.dentalsoftDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView_Costos
            // 
            this.dataGridView_Costos.AutoGenerateColumns = false;
            this.dataGridView_Costos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_Costos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Costos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clavecostosDataGridViewTextBoxColumn,
            this.nompacienteDataGridViewTextBoxColumn,
            this.clavetratamientoDataGridViewTextBoxColumn,
            this.nomtratamientoDataGridViewTextBoxColumn,
            this.adeudopacienteDataGridViewTextBoxColumn,
            this.abonadopacienteDataGridViewTextBoxColumn,
            this.costoextraDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView_Costos.DataSource = this.costosBindingSource;
            this.dataGridView_Costos.Location = new System.Drawing.Point(26, 87);
            this.dataGridView_Costos.Name = "dataGridView_Costos";
            this.dataGridView_Costos.ReadOnly = true;
            this.dataGridView_Costos.Size = new System.Drawing.Size(823, 222);
            this.dataGridView_Costos.TabIndex = 3;
            this.dataGridView_Costos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Costos_CellContentClick);
            // 
            // clavecostosDataGridViewTextBoxColumn
            // 
            this.clavecostosDataGridViewTextBoxColumn.DataPropertyName = "clave_costos";
            this.clavecostosDataGridViewTextBoxColumn.HeaderText = "Clave";
            this.clavecostosDataGridViewTextBoxColumn.Name = "clavecostosDataGridViewTextBoxColumn";
            this.clavecostosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nompacienteDataGridViewTextBoxColumn
            // 
            this.nompacienteDataGridViewTextBoxColumn.DataPropertyName = "nom_paciente";
            this.nompacienteDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nompacienteDataGridViewTextBoxColumn.Name = "nompacienteDataGridViewTextBoxColumn";
            this.nompacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clavetratamientoDataGridViewTextBoxColumn
            // 
            this.clavetratamientoDataGridViewTextBoxColumn.DataPropertyName = "clave_tratamiento";
            this.clavetratamientoDataGridViewTextBoxColumn.HeaderText = "Clave tratamiento";
            this.clavetratamientoDataGridViewTextBoxColumn.Name = "clavetratamientoDataGridViewTextBoxColumn";
            this.clavetratamientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomtratamientoDataGridViewTextBoxColumn
            // 
            this.nomtratamientoDataGridViewTextBoxColumn.DataPropertyName = "nom_tratamiento";
            this.nomtratamientoDataGridViewTextBoxColumn.HeaderText = "Tratamiento";
            this.nomtratamientoDataGridViewTextBoxColumn.Name = "nomtratamientoDataGridViewTextBoxColumn";
            this.nomtratamientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adeudopacienteDataGridViewTextBoxColumn
            // 
            this.adeudopacienteDataGridViewTextBoxColumn.DataPropertyName = "adeudo_paciente";
            this.adeudopacienteDataGridViewTextBoxColumn.HeaderText = "Adeudo";
            this.adeudopacienteDataGridViewTextBoxColumn.Name = "adeudopacienteDataGridViewTextBoxColumn";
            this.adeudopacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // abonadopacienteDataGridViewTextBoxColumn
            // 
            this.abonadopacienteDataGridViewTextBoxColumn.DataPropertyName = "abonado_paciente";
            this.abonadopacienteDataGridViewTextBoxColumn.HeaderText = "Abonado";
            this.abonadopacienteDataGridViewTextBoxColumn.Name = "abonadopacienteDataGridViewTextBoxColumn";
            this.abonadopacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costoextraDataGridViewTextBoxColumn
            // 
            this.costoextraDataGridViewTextBoxColumn.DataPropertyName = "costo_extra";
            this.costoextraDataGridViewTextBoxColumn.HeaderText = "Costo extra";
            this.costoextraDataGridViewTextBoxColumn.Name = "costoextraDataGridViewTextBoxColumn";
            this.costoextraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costosBindingSource
            // 
            this.costosBindingSource.DataMember = "costos";
            this.costosBindingSource.DataSource = this.dentalsoftDataSet4;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(758, 407);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(91, 23);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cliente: ";
            // 
            // txt_buscar_p
            // 
            this.txt_buscar_p.Location = new System.Drawing.Point(262, 22);
            this.txt_buscar_p.Name = "txt_buscar_p";
            this.txt_buscar_p.Size = new System.Drawing.Size(266, 20);
            this.txt_buscar_p.TabIndex = 8;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(543, 20);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 9;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click_1);
            // 
            // Costos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Dentalsof.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 442);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar_p);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.dataGridView_Costos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Costos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Costos";
            this.Load += new System.EventHandler(this.Costos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dentalsoftDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Costos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Costos;
        private System.Windows.Forms.Button btn_salir;
        //private DENTALSOFTDataSet dENTALSOFTDataSet;
        private System.Windows.Forms.BindingSource costosBindingSource;
        private DENTALSOFTDataSet4 dentalsoftDataSet4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar_p;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clavecostosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nompacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clavetratamientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomtratamientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adeudopacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abonadopacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoextraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}
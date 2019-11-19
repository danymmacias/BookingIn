namespace Dentalsof
{
    partial class Tratamientos
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
            Dentalsof.DENTALSOFTDataSet dentalsoftDataSet1 = new Dentalsof.DENTALSOFTDataSet();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tratamientos));
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtbcostot = new System.Windows.Forms.TextBox();
            this.txtbnombret = new System.Windows.Forms.TextBox();
            this.txtbclavet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dataGridView_Tratamientos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratamientosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dENTALSOFTDataSet2 = new Dentalsof.DENTALSOFTDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tratamientosTableAdapter = new Dentalsof.DENTALSOFTDataSet2TableAdapters.tratamientosTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tratamientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tratamientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dENTALSOFTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimpiar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlimpiar.Location = new System.Drawing.Point(552, 326);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 30;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnactualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnactualizar.Location = new System.Drawing.Point(32, 326);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 29;
            this.btnactualizar.Text = "Editar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Visible = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(441, 19);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(214, 20);
            this.txtbuscar.TabIndex = 28;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(301, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Buscar Tratamiento:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnbuscar.Location = new System.Drawing.Point(679, 14);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(74, 25);
            this.btnbuscar.TabIndex = 26;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btneliminar.Location = new System.Drawing.Point(26, 326);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 25;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtbcostot
            // 
            this.txtbcostot.Location = new System.Drawing.Point(94, 172);
            this.txtbcostot.Name = "txtbcostot";
            this.txtbcostot.Size = new System.Drawing.Size(100, 20);
            this.txtbcostot.TabIndex = 24;
            this.txtbcostot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbcostot_KeyPress);
            // 
            // txtbnombret
            // 
            this.txtbnombret.Location = new System.Drawing.Point(94, 113);
            this.txtbnombret.Multiline = true;
            this.txtbnombret.Name = "txtbnombret";
            this.txtbnombret.Size = new System.Drawing.Size(153, 23);
            this.txtbnombret.TabIndex = 23;
            this.txtbnombret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbnombret_KeyPress);
            // 
            // txtbclavet
            // 
            this.txtbclavet.Location = new System.Drawing.Point(93, 68);
            this.txtbclavet.Name = "txtbclavet";
            this.txtbclavet.ReadOnly = true;
            this.txtbclavet.Size = new System.Drawing.Size(100, 20);
            this.txtbclavet.TabIndex = 22;
            this.txtbclavet.TextChanged += new System.EventHandler(this.txtbclavet_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Datos de tratamientos.";
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_salir.Location = new System.Drawing.Point(653, 326);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 20;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click_1);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_agregar.Location = new System.Drawing.Point(89, 238);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 19;
            this.btn_agregar.Text = "Guardar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dataGridView_Tratamientos
            // 
            this.dataGridView_Tratamientos.AutoGenerateColumns = false;
            this.dataGridView_Tratamientos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_Tratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tratamientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView_Tratamientos.DataSource = this.tratamientosBindingSource1;
            this.dataGridView_Tratamientos.EnableHeadersVisualStyles = false;
            this.dataGridView_Tratamientos.Location = new System.Drawing.Point(304, 68);
            this.dataGridView_Tratamientos.Name = "dataGridView_Tratamientos";
            this.dataGridView_Tratamientos.ReadOnly = true;
            this.dataGridView_Tratamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_Tratamientos.Size = new System.Drawing.Size(409, 209);
            this.dataGridView_Tratamientos.TabIndex = 18;
            this.dataGridView_Tratamientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Tratamientos_CellContentClick);
            this.dataGridView_Tratamientos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Tratamientos_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "clave_tratamiento";
            this.dataGridViewTextBoxColumn1.HeaderText = "Clave ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nom_tratamiento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "costo_tratamiento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Costo ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tratamientosBindingSource1
            // 
            this.tratamientosBindingSource1.DataMember = "tratamientos";
            this.tratamientosBindingSource1.DataSource = this.dENTALSOFTDataSet2;
            // 
            // dENTALSOFTDataSet2
            // 
            this.dENTALSOFTDataSet2.DataSetName = "DENTALSOFTDataSet2";
            this.dENTALSOFTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Clave:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Costo:";
            // 
            // tratamientosTableAdapter
            // 
            this.tratamientosTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tratamientosBindingSource
            // 
            dentalsoftDataSet1.DataSetName = "DENTALSOFTDataSet";
            dentalsoftDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.tratamientosBindingSource.DataSource = dentalsoftDataSet1;
            this.tratamientosBindingSource.Position = 0;
            // 
            // Tratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::Dentalsof.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 375);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.txtbcostot);
            this.Controls.Add(this.txtbnombret);
            this.Controls.Add(this.txtbclavet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dataGridView_Tratamientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tratamientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tratamientos";
            this.Load += new System.EventHandler(this.Tratamientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tratamientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dENTALSOFTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txtbcostot;
        private System.Windows.Forms.TextBox txtbnombret;
        private System.Windows.Forms.TextBox txtbclavet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dataGridView_Tratamientos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        //private DENTALSOFTDataSet dENTALSOFTDataSet;
        private System.Windows.Forms.BindingSource tratamientosBindingSource;
        //private DENTALSOFTDataSetTableAdapters.tratamientosTableAdapter tratamientosTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn clavetratamientoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nomtratamientoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn costotratamientoDataGridViewTextBoxColumn;
        private DENTALSOFTDataSet2 dENTALSOFTDataSet2;
        private System.Windows.Forms.BindingSource tratamientosBindingSource1;
        private DENTALSOFTDataSet2TableAdapters.tratamientosTableAdapter tratamientosTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    }
}
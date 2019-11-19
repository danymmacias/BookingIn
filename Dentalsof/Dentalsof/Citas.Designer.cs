namespace Dentalsof
{
    partial class Citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Citas));
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.pACIENTENUEVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dENTALSOFTDataSet1 = new Dentalsof.DENTALSOFTDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.btn_reagendar = new System.Windows.Forms.Button();
            this.btn_clientes_nuevos = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_hora = new System.Windows.Forms.ComboBox();
            this.cmb_tratamientos = new System.Windows.Forms.ComboBox();
            this.tratamientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dENTALSOFTDataSet2 = new Dentalsof.DENTALSOFTDataSet2();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.pACIENTE_NUEVOTableAdapter = new Dentalsof.DENTALSOFTDataSet1TableAdapters.PACIENTE_NUEVOTableAdapter();
            this.tratamientosTableAdapter = new Dentalsof.DENTALSOFTDataSet2TableAdapters.tratamientosTableAdapter();
            this.dENTALSOFTDataSet3 = new Dentalsof.DENTALSOFTDataSet3();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaTableAdapter = new Dentalsof.DENTALSOFTDataSet3TableAdapters.agendaTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTENUEVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dENTALSOFTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dENTALSOFTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dENTALSOFTDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_cliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(129, 37);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(230, 24);
            this.cmb_cliente.Sorted = true;
            this.cmb_cliente.TabIndex = 1;
            this.cmb_cliente.SelectedIndexChanged += new System.EventHandler(this.cmb_cliente_SelectedIndexChanged_1);
            // 
            // pACIENTENUEVOBindingSource
            // 
            this.pACIENTENUEVOBindingSource.DataMember = "PACIENTE_NUEVO";
            this.pACIENTENUEVOBindingSource.DataSource = this.dENTALSOFTDataSet1;
            // 
            // dENTALSOFTDataSet1
            // 
            this.dENTALSOFTDataSet1.DataSetName = "DENTALSOFTDataSet1";
            this.dENTALSOFTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tratamiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfono:";
            // 
            // txt_tel
            // 
            this.txt_tel.BackColor = System.Drawing.SystemColors.Window;
            this.txt_tel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel.Location = new System.Drawing.Point(129, 67);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.ReadOnly = true;
            this.txt_tel.Size = new System.Drawing.Size(170, 22);
            this.txt_tel.TabIndex = 2;
            this.txt_tel.Text = "\r\n";
            this.txt_tel.TextChanged += new System.EventHandler(this.cmb_cliente_SelectedIndexChanged_1);
            // 
            // btn_reagendar
            // 
            this.btn_reagendar.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_reagendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reagendar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reagendar.Location = new System.Drawing.Point(484, 34);
            this.btn_reagendar.Name = "btn_reagendar";
            this.btn_reagendar.Size = new System.Drawing.Size(94, 29);
            this.btn_reagendar.TabIndex = 10;
            this.btn_reagendar.Text = "Agendar";
            this.btn_reagendar.UseVisualStyleBackColor = false;
            this.btn_reagendar.Click += new System.EventHandler(this.btn_reagendar_Click);
            // 
            // btn_clientes_nuevos
            // 
            this.btn_clientes_nuevos.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_clientes_nuevos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes_nuevos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes_nuevos.Location = new System.Drawing.Point(484, 70);
            this.btn_clientes_nuevos.Name = "btn_clientes_nuevos";
            this.btn_clientes_nuevos.Size = new System.Drawing.Size(94, 26);
            this.btn_clientes_nuevos.TabIndex = 7;
            this.btn_clientes_nuevos.Text = "Nuevo";
            this.btn_clientes_nuevos.UseVisualStyleBackColor = false;
            this.btn_clientes_nuevos.Click += new System.EventHandler(this.btn_clientes_nuevos_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(484, 155);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(94, 23);
            this.btn_salir.TabIndex = 11;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dtpDia
            // 
            this.dtpDia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDia.Location = new System.Drawing.Point(129, 124);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(135, 22);
            this.dtpDia.TabIndex = 12;
            this.dtpDia.ValueChanged += new System.EventHandler(this.dtpDia_ValueChanged);
            this.dtpDia.StyleChanged += new System.EventHandler(this.dtpDia_StyleChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hora:";
            // 
            // cmb_hora
            // 
            this.cmb_hora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_hora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_hora.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_hora.FormattingEnabled = true;
            this.cmb_hora.Items.AddRange(new object[] {
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30 ",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "4:00 pm",
            "4:30 pm",
            "5:00 pm",
            "5:30 pm",
            "6:00 pm",
            "6:30 pm",
            "7:00 pm",
            "7:30 pm"});
            this.cmb_hora.Location = new System.Drawing.Point(129, 157);
            this.cmb_hora.Name = "cmb_hora";
            this.cmb_hora.Size = new System.Drawing.Size(135, 24);
            this.cmb_hora.TabIndex = 14;
            this.cmb_hora.SelectedIndexChanged += new System.EventHandler(this.cmb_hora_SelectedIndexChanged);
            // 
            // cmb_tratamientos
            // 
            this.cmb_tratamientos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tratamientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_tratamientos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tratamientos.FormattingEnabled = true;
            this.cmb_tratamientos.Location = new System.Drawing.Point(129, 95);
            this.cmb_tratamientos.Name = "cmb_tratamientos";
            this.cmb_tratamientos.Size = new System.Drawing.Size(170, 24);
            this.cmb_tratamientos.Sorted = true;
            this.cmb_tratamientos.TabIndex = 15;
            this.cmb_tratamientos.SelectedIndexChanged += new System.EventHandler(this.cmb_tratamientos_SelectedIndexChanged);
            // 
            // tratamientosBindingSource
            // 
            this.tratamientosBindingSource.DataMember = "tratamientos";
            this.tratamientosBindingSource.DataSource = this.dENTALSOFTDataSet2;
            // 
            // dENTALSOFTDataSet2
            // 
            this.dENTALSOFTDataSet2.DataSetName = "DENTALSOFTDataSet2";
            this.dENTALSOFTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(129, 11);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(40, 22);
            this.txt_ID.TabIndex = 16;
            this.txt_ID.TextChanged += new System.EventHandler(this.cmb_cliente_SelectedIndexChanged_1);
            // 
            // pACIENTE_NUEVOTableAdapter
            // 
            this.pACIENTE_NUEVOTableAdapter.ClearBeforeFill = true;
            // 
            // tratamientosTableAdapter
            // 
            this.tratamientosTableAdapter.ClearBeforeFill = true;
            // 
            // dENTALSOFTDataSet3
            // 
            this.dENTALSOFTDataSet3.DataSetName = "DENTALSOFTDataSet3";
            this.dENTALSOFTDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "agenda";
            this.agendaBindingSource.DataSource = this.dENTALSOFTDataSet3;
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "No.";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_precio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(335, 100);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(16, 16);
            this.lbl_precio.TabIndex = 19;
            this.lbl_precio.Text = "--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(316, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "$";
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(484, 105);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(94, 29);
            this.btnCliente.TabIndex = 21;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::Dentalsof.Properties.Resources.fondo21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(601, 220);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.cmb_tratamientos);
            this.Controls.Add(this.cmb_hora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDia);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_clientes_nuevos);
            this.Controls.Add(this.btn_reagendar);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Citas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Cita";
            this.Load += new System.EventHandler(this.Citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTENUEVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dENTALSOFTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dENTALSOFTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dENTALSOFTDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Button btn_reagendar;
        private System.Windows.Forms.Button btn_clientes_nuevos;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_hora;
        private DENTALSOFTDataSet1 dENTALSOFTDataSet1;
        private System.Windows.Forms.BindingSource pACIENTENUEVOBindingSource;
        private DENTALSOFTDataSet1TableAdapters.PACIENTE_NUEVOTableAdapter pACIENTE_NUEVOTableAdapter;
        private DENTALSOFTDataSet2 dENTALSOFTDataSet2;
        private System.Windows.Forms.BindingSource tratamientosBindingSource;
        private DENTALSOFTDataSet2TableAdapters.tratamientosTableAdapter tratamientosTableAdapter;
        private DENTALSOFTDataSet3 dENTALSOFTDataSet3;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private DENTALSOFTDataSet3TableAdapters.agendaTableAdapter agendaTableAdapter;
        private System.Windows.Forms.ComboBox cmb_cliente;
        public System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmb_tratamientos;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCliente;
    }
}
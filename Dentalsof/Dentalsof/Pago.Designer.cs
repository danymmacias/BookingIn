namespace Dentalsof
{
    partial class Pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pago));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_nomtratamiento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_extra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.btn_total = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nom.Location = new System.Drawing.Point(173, 34);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(79, 13);
            this.lbl_nom.TabIndex = 0;
            this.lbl_nom.Text = "Nombre Cliente";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(311, 236);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 13);
            this.lbl_total.TabIndex = 6;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(354, 294);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_guardar.Enabled = false;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Location = new System.Drawing.Point(255, 294);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Motivo Tratamiento:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbl_nomtratamiento
            // 
            this.lbl_nomtratamiento.AutoSize = true;
            this.lbl_nomtratamiento.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nomtratamiento.Location = new System.Drawing.Point(174, 62);
            this.lbl_nomtratamiento.Name = "lbl_nomtratamiento";
            this.lbl_nomtratamiento.Size = new System.Drawing.Size(96, 13);
            this.lbl_nomtratamiento.TabIndex = 9;
            this.lbl_nomtratamiento.Text = "Nombe tratamiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripción:";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(177, 122);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(208, 61);
            this.txt_desc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Costo extra:";
            // 
            // txt_extra
            // 
            this.txt_extra.Location = new System.Drawing.Point(176, 197);
            this.txt_extra.Name = "txt_extra";
            this.txt_extra.Size = new System.Drawing.Size(94, 20);
            this.txt_extra.TabIndex = 3;
            this.txt_extra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_extra_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Costo tratamiento:";
            // 
            // txt_costo
            // 
            this.txt_costo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_costo.Location = new System.Drawing.Point(176, 89);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.ReadOnly = true;
            this.txt_costo.Size = new System.Drawing.Size(94, 20);
            this.txt_costo.TabIndex = 1;
            // 
            // btn_total
            // 
            this.btn_total.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_total.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_total.Location = new System.Drawing.Point(177, 236);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(75, 23);
            this.btn_total.TabIndex = 15;
            this.btn_total.Text = "Total";
            this.btn_total.UseVisualStyleBackColor = false;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "$";
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Dentalsof.Properties.Resources.fondo21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(456, 329);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.txt_costo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_extra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_nomtratamiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.Pago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lbl_nomtratamiento;
        public System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_extra;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.Label label5;
    }
}
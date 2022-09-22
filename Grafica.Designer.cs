
namespace grafica
{
    partial class Grafica
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafica));
            this.btn_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.barra = new System.Windows.Forms.TextBox();
            this.btn_generarplanilla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_recibos = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.total_label = new System.Windows.Forms.Label();
            this.cuota_label = new System.Windows.Forms.Label();
            this.importe_label = new System.Windows.Forms.Label();
            this.endoso_label = new System.Windows.Forms.Label();
            this.poliza_label = new System.Windows.Forms.Label();
            this.rama_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_sigbarra = new System.Windows.Forms.Label();
            this.muestra_lista = new System.Windows.Forms.DataGridView();
            this.panel_recibos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muestra_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Lime;
            this.btn_salir.ForeColor = System.Drawing.Color.Black;
            this.btn_salir.Location = new System.Drawing.Point(825, 13);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(355, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Planillas";
            // 
            // barra
            // 
            this.barra.AllowDrop = true;
            this.barra.Location = new System.Drawing.Point(12, 65);
            this.barra.Name = "barra";
            this.barra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.barra.Size = new System.Drawing.Size(399, 23);
            this.barra.TabIndex = 0;
            this.barra.Text = "ingrese aqui el código de barras";
            this.barra.WordWrap = false;
            this.barra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.barra_KeyPress);
            // 
            // btn_generarplanilla
            // 
            this.btn_generarplanilla.Location = new System.Drawing.Point(719, 238);
            this.btn_generarplanilla.Name = "btn_generarplanilla";
            this.btn_generarplanilla.Size = new System.Drawing.Size(118, 23);
            this.btn_generarplanilla.TabIndex = 3;
            this.btn_generarplanilla.Text = "Generar planilla";
            this.btn_generarplanilla.UseVisualStyleBackColor = true;
            this.btn_generarplanilla.Click += new System.EventHandler(this.Btn_generarplanilla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(211, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Generar planillas de cobranzas";
            // 
            // panel_recibos
            // 
            this.panel_recibos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(22)))), ((int)(((byte)(105)))));
            this.panel_recibos.Controls.Add(this.pictureBox2);
            this.panel_recibos.Controls.Add(this.label9);
            this.panel_recibos.Controls.Add(this.pictureBox1);
            this.panel_recibos.Controls.Add(this.total_label);
            this.panel_recibos.Controls.Add(this.cuota_label);
            this.panel_recibos.Controls.Add(this.importe_label);
            this.panel_recibos.Controls.Add(this.endoso_label);
            this.panel_recibos.Controls.Add(this.poliza_label);
            this.panel_recibos.Controls.Add(this.rama_label);
            this.panel_recibos.Controls.Add(this.label8);
            this.panel_recibos.Controls.Add(this.label5);
            this.panel_recibos.Controls.Add(this.label4);
            this.panel_recibos.Controls.Add(this.label3);
            this.panel_recibos.Controls.Add(this.label6);
            this.panel_recibos.Controls.Add(this.label7);
            this.panel_recibos.Location = new System.Drawing.Point(12, 94);
            this.panel_recibos.Name = "panel_recibos";
            this.panel_recibos.Size = new System.Drawing.Size(888, 75);
            this.panel_recibos.TabIndex = 6;
            this.panel_recibos.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::grafica.Properties.Resources.error;
            this.pictureBox2.Location = new System.Drawing.Point(783, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(49)))), ((int)(((byte)(232)))));
            this.label9.Location = new System.Drawing.Point(707, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "Lectura Correcta";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(831, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.total_label.Location = new System.Drawing.Point(613, 40);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(48, 23);
            this.total_label.TabIndex = 24;
            this.total_label.Text = "Total";
            // 
            // cuota_label
            // 
            this.cuota_label.AutoSize = true;
            this.cuota_label.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cuota_label.Location = new System.Drawing.Point(502, 39);
            this.cuota_label.Name = "cuota_label";
            this.cuota_label.Size = new System.Drawing.Size(98, 23);
            this.cuota_label.TabIndex = 23;
            this.cuota_label.Text = "cuota_label";
            // 
            // importe_label
            // 
            this.importe_label.AutoSize = true;
            this.importe_label.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.importe_label.Location = new System.Drawing.Point(366, 39);
            this.importe_label.Name = "importe_label";
            this.importe_label.Size = new System.Drawing.Size(113, 23);
            this.importe_label.TabIndex = 22;
            this.importe_label.Text = "importe_label";
            // 
            // endoso_label
            // 
            this.endoso_label.AutoSize = true;
            this.endoso_label.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.endoso_label.Location = new System.Drawing.Point(269, 40);
            this.endoso_label.Name = "endoso_label";
            this.endoso_label.Size = new System.Drawing.Size(113, 23);
            this.endoso_label.TabIndex = 21;
            this.endoso_label.Text = "endoso_label";
            // 
            // poliza_label
            // 
            this.poliza_label.AutoSize = true;
            this.poliza_label.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.poliza_label.Location = new System.Drawing.Point(119, 39);
            this.poliza_label.Name = "poliza_label";
            this.poliza_label.Size = new System.Drawing.Size(100, 23);
            this.poliza_label.TabIndex = 20;
            this.poliza_label.Text = "poliza_label";
            // 
            // rama_label
            // 
            this.rama_label.AutoSize = true;
            this.rama_label.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rama_label.Location = new System.Drawing.Point(34, 39);
            this.rama_label.Name = "rama_label";
            this.rama_label.Size = new System.Drawing.Size(48, 23);
            this.rama_label.TabIndex = 19;
            this.rama_label.Text = "rama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(613, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(483, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cuota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(366, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Importe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(243, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Endoso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(119, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "Póliza";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(13, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "Rama";
            // 
            // label_sigbarra
            // 
            this.label_sigbarra.AutoSize = true;
            this.label_sigbarra.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_sigbarra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_sigbarra.Location = new System.Drawing.Point(416, 67);
            this.label_sigbarra.Name = "label_sigbarra";
            this.label_sigbarra.Size = new System.Drawing.Size(466, 21);
            this.label_sigbarra.TabIndex = 8;
            this.label_sigbarra.Text = "<=== escanee su próximo recibo o presione \"Generar Planilla\"";
            this.label_sigbarra.Visible = false;
            // 
            // muestra_lista
            // 
            this.muestra_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.muestra_lista.Location = new System.Drawing.Point(12, 175);
            this.muestra_lista.Name = "muestra_lista";
            this.muestra_lista.ReadOnly = true;
            this.muestra_lista.RowTemplate.Height = 25;
            this.muestra_lista.Size = new System.Drawing.Size(617, 477);
            this.muestra_lista.TabIndex = 9;
            // 
            // Grafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(901, 660);
            this.Controls.Add(this.muestra_lista);
            this.Controls.Add(this.label_sigbarra);
            this.Controls.Add(this.panel_recibos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_generarplanilla);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salir);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Grafica";
            this.Text = "Seguros";
            this.Load += new System.EventHandler(this.Grafica_Load);
            this.panel_recibos.ResumeLayout(false);
            this.panel_recibos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muestra_lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barra;
        private System.Windows.Forms.Button btn_generarplanilla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_recibos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label cuota_label;
        private System.Windows.Forms.Label importe_label;
        private System.Windows.Forms.Label endoso_label;
        private System.Windows.Forms.Label poliza_label;
        private System.Windows.Forms.Label rama_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_sigbarra;
        private System.Windows.Forms.DataGridView muestra_lista;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


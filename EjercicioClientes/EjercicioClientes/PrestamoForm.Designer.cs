namespace EjercicioClientes
{
    partial class PrestamoForm
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
            this.txtComision = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtTNA = new System.Windows.Forms.TextBox();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lstTipoPrestamos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(1021, 538);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(232, 26);
            this.txtComision.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(829, 543);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 25);
            this.label9.TabIndex = 42;
            this.label9.Text = "Comisión Total";
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.ItemHeight = 20;
            this.lstPrestamos.Location = new System.Drawing.Point(825, 86);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(451, 424);
            this.lstPrestamos.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(855, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(381, 29);
            this.label8.TabIndex = 40;
            this.label8.Text = "PRÉSTAMOS DADOS DE ALTA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "TIPOS PRÉSTAMO";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(482, 581);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(298, 39);
            this.btnAlta.TabIndex = 38;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(600, 512);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(180, 26);
            this.txtCuota.TabIndex = 37;
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(600, 458);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(180, 26);
            this.txtInteres.TabIndex = 36;
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(599, 408);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(182, 26);
            this.txtCapital.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Cuota Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Cuota (Interés)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cuota (Capital)";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(482, 335);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(298, 39);
            this.btnSimular.TabIndex = 31;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // txtPlazo
            // 
            this.txtPlazo.Enabled = false;
            this.txtPlazo.Location = new System.Drawing.Point(596, 279);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(185, 26);
            this.txtPlazo.TabIndex = 30;
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(596, 211);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(185, 26);
            this.txtMonto.TabIndex = 29;
            // 
            // txtTNA
            // 
            this.txtTNA.Location = new System.Drawing.Point(596, 154);
            this.txtTNA.Name = "txtTNA";
            this.txtTNA.Size = new System.Drawing.Size(185, 26);
            this.txtTNA.TabIndex = 28;
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(596, 86);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(185, 26);
            this.txtLinea.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Plazo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Monto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "TNA";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(478, 86);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(48, 20);
            this.lbl.TabIndex = 23;
            this.lbl.Text = "Línea";
            // 
            // lstTipoPrestamos
            // 
            this.lstTipoPrestamos.FormattingEnabled = true;
            this.lstTipoPrestamos.ItemHeight = 20;
            this.lstTipoPrestamos.Location = new System.Drawing.Point(23, 86);
            this.lstTipoPrestamos.Name = "lstTipoPrestamos";
            this.lstTipoPrestamos.Size = new System.Drawing.Size(385, 484);
            this.lstTipoPrestamos.TabIndex = 22;
            this.lstTipoPrestamos.SelectedIndexChanged += new System.EventHandler(this.lstTipoPrestamos_SelectedIndexChanged_1);
            // 
            // PrestamoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1301, 631);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstPrestamos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.txtPlazo);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtTNA);
            this.Controls.Add(this.txtLinea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lstTipoPrestamos);
            this.Name = "PrestamoForm";
            this.Text = "FormularioForm";
            this.Load += new System.EventHandler(this.PrestamoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtTNA;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ListBox lstTipoPrestamos;
    }
}
namespace EjercicioClientes
{
    partial class Menu
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
            this.altaClientes = new System.Windows.Forms.Button();
            this.listarClientes = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.btnAltaCuenta = new System.Windows.Forms.Button();
            this.btnListarCuentas = new System.Windows.Forms.Button();
            this.lstCuentas = new System.Windows.Forms.ListBox();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // altaClientes
            // 
            this.altaClientes.Location = new System.Drawing.Point(100, 46);
            this.altaClientes.Name = "altaClientes";
            this.altaClientes.Size = new System.Drawing.Size(245, 60);
            this.altaClientes.TabIndex = 0;
            this.altaClientes.Text = "Alta Clientes";
            this.altaClientes.UseVisualStyleBackColor = true;
            this.altaClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // listarClientes
            // 
            this.listarClientes.Location = new System.Drawing.Point(100, 142);
            this.listarClientes.Name = "listarClientes";
            this.listarClientes.Size = new System.Drawing.Size(245, 60);
            this.listarClientes.TabIndex = 1;
            this.listarClientes.Text = "Listar Clientes";
            this.listarClientes.UseVisualStyleBackColor = true;
            this.listarClientes.Click += new System.EventHandler(this.listarClientes_Click);
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 20;
            this.lstClientes.Location = new System.Drawing.Point(12, 244);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(441, 144);
            this.lstClientes.TabIndex = 2;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAltaCuenta
            // 
            this.btnAltaCuenta.Location = new System.Drawing.Point(708, 46);
            this.btnAltaCuenta.Name = "btnAltaCuenta";
            this.btnAltaCuenta.Size = new System.Drawing.Size(245, 60);
            this.btnAltaCuenta.TabIndex = 3;
            this.btnAltaCuenta.Text = "Alta Cuenta";
            this.btnAltaCuenta.UseVisualStyleBackColor = true;
            this.btnAltaCuenta.Click += new System.EventHandler(this.btnAltaCuenta_Click);
            // 
            // btnListarCuentas
            // 
            this.btnListarCuentas.Location = new System.Drawing.Point(708, 142);
            this.btnListarCuentas.Name = "btnListarCuentas";
            this.btnListarCuentas.Size = new System.Drawing.Size(245, 60);
            this.btnListarCuentas.TabIndex = 4;
            this.btnListarCuentas.Text = "Listar Cuentas";
            this.btnListarCuentas.UseVisualStyleBackColor = true;
            this.btnListarCuentas.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstCuentas
            // 
            this.lstCuentas.FormattingEnabled = true;
            this.lstCuentas.ItemHeight = 20;
            this.lstCuentas.Location = new System.Drawing.Point(624, 244);
            this.lstCuentas.Name = "lstCuentas";
            this.lstCuentas.Size = new System.Drawing.Size(441, 144);
            this.lstCuentas.TabIndex = 5;
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Location = new System.Drawing.Point(189, 430);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(124, 46);
            this.btnPrestamos.TabIndex = 6;
            this.btnPrestamos.Text = "Préstamos";
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 575);
            this.Controls.Add(this.btnPrestamos);
            this.Controls.Add(this.lstCuentas);
            this.Controls.Add(this.btnListarCuentas);
            this.Controls.Add(this.btnAltaCuenta);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.listarClientes);
            this.Controls.Add(this.altaClientes);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button altaClientes;
        private System.Windows.Forms.Button listarClientes;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Button btnAltaCuenta;
        private System.Windows.Forms.Button btnListarCuentas;
        private System.Windows.Forms.ListBox lstCuentas;
        private System.Windows.Forms.Button btnPrestamos;
    }
}


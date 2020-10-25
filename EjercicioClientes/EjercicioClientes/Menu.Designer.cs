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
            this.SuspendLayout();
            // 
            // altaClientes
            // 
            this.altaClientes.Location = new System.Drawing.Point(236, 52);
            this.altaClientes.Name = "altaClientes";
            this.altaClientes.Size = new System.Drawing.Size(245, 60);
            this.altaClientes.TabIndex = 0;
            this.altaClientes.Text = "Alta Clientes";
            this.altaClientes.UseVisualStyleBackColor = true;
            this.altaClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // listarClientes
            // 
            this.listarClientes.Location = new System.Drawing.Point(236, 155);
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
            this.lstClientes.Location = new System.Drawing.Point(236, 243);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(120, 84);
            this.lstClientes.TabIndex = 2;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 430);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.listarClientes);
            this.Controls.Add(this.altaClientes);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button altaClientes;
        private System.Windows.Forms.Button listarClientes;
        private System.Windows.Forms.ListBox lstClientes;
    }
}


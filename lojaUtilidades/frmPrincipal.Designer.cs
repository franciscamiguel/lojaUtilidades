
namespace lojaUtilidades
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNovoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVendedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVendas,
            this.tsmCliente,
            this.tsmVendedor,
            this.tsmSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
          
            // 
            // tsmVendas
            // 
            this.tsmVendas.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.tsmVendas.Name = "tsmVendas";
            this.tsmVendas.Size = new System.Drawing.Size(63, 20);
            this.tsmVendas.Text = "VENDAS";
            // 
            // tsmCliente
            // 
            this.tsmCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNovoCliente});
            this.tsmCliente.Name = "tsmCliente";
            this.tsmCliente.Size = new System.Drawing.Size(63, 20);
            this.tsmCliente.Text = "CLIENTE";
            // 
            // tsmNovoCliente
            // 
            this.tsmNovoCliente.Name = "tsmNovoCliente";
            this.tsmNovoCliente.Size = new System.Drawing.Size(103, 22);
            this.tsmNovoCliente.Text = "Novo";
            this.tsmNovoCliente.Click += new System.EventHandler(this.tsmNovoCliente_Click);
            // 
            // tsmVendedor
            // 
            this.tsmVendedor.Name = "tsmVendedor";
            this.tsmVendedor.Size = new System.Drawing.Size(79, 20);
            this.tsmVendedor.Text = "VENDEDOR";
            // 
            // tsmSobre
            // 
            this.tsmSobre.Name = "tsmSobre";
            this.tsmSobre.Size = new System.Drawing.Size(54, 20);
            this.tsmSobre.Text = "SOBRE";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 179);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Janela principal";
   
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmVendas;
        private System.Windows.Forms.ToolStripMenuItem tsmCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmNovoCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmVendedor;
        private System.Windows.Forms.ToolStripMenuItem tsmSobre;
    }
}


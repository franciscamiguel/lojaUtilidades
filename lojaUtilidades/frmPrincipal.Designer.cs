
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
            this.tsmFronecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNovoFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVendas,
            this.tsmCliente,
            this.tsmVendedor,
            this.tsmFronecedor,
            this.tsmSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // tsmFronecedor
            // 
            this.tsmFronecedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNovoFornecedor});
            this.tsmFronecedor.Name = "tsmFronecedor";
            this.tsmFronecedor.Size = new System.Drawing.Size(79, 20);
            this.tsmFronecedor.Text = "Fornecedor";
            // 
            // tsmNovoFornecedor
            // 
            this.tsmNovoFornecedor.Name = "tsmNovoFornecedor";
            this.tsmNovoFornecedor.Size = new System.Drawing.Size(103, 22);
            this.tsmNovoFornecedor.Text = "Novo";
            this.tsmNovoFornecedor.Click += new System.EventHandler(this.tsmNovoFornecedor_Click);
            // 
            // tsmSobre
            // 
            this.tsmSobre.Name = "tsmSobre";
            this.tsmSobre.Size = new System.Drawing.Size(54, 20);
            this.tsmSobre.Text = "SOBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vendedor";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(106, 38);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(121, 23);
            this.cmbVendedor.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(77, -43);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(54, 19);
            this.chkAtivo.TabIndex = 5;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.CheckedChanged += new System.EventHandler(this.chkAtivo_CheckedChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 179);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.CheckBox chkAtivo;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbVendedor;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem tsmFronecedor;
        private System.Windows.Forms.ToolStripMenuItem tsmNovoFornecedor;
    }
}


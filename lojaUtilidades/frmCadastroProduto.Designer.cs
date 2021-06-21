
namespace lojaUtilidades
{
    partial class frmCadastroProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdepartamento = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(12, 31);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 23);
            this.txtnome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(12, 98);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(100, 23);
            this.txttipo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(12, 164);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 23);
            this.txtvalor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Departamento";
            // 
            // txtdepartamento
            // 
            this.txtdepartamento.Location = new System.Drawing.Point(222, 31);
            this.txtdepartamento.Name = "txtdepartamento";
            this.txtdepartamento.Size = new System.Drawing.Size(168, 23);
            this.txtdepartamento.TabIndex = 7;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(248, 98);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 23);
            this.txtid.TabIndex = 8;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(44, 232);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 9;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(202, 232);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtdepartamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroProduto";
            this.Text = "frmCadastroProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtdepartamento;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.Button btnsalvar;
    }
}
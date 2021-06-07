using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lojaUtilidades
{
    public partial class FrmVendedor : Form
    {
        public FrmVendedor()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ClVendedor vendedor = new ClVendedor();
             vendedor.nome = txtNome.Text;
            vendedor.telefone = mskTelefone.Text;
            vendedor.situacao = chkAtivo.Checked;


            if (txtId.Text == "")
            {
                txtId.Text = vendedor.Salvar().ToString();
            }
            else
            {
                vendedor.cod_vendedor= Convert.ToInt32(txtId.Text);
                vendedor.Atualizar();
                this.Close();

            }
        }
    }
}

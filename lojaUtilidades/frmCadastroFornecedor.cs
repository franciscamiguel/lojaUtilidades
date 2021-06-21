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
    public partial class frmCadastroFornecedor : Form
    {
        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            ClFornecedor fornecedor = new ClFornecedor();
            fornecedor.nome = txtNome.Text;
            fornecedor.telefone = maskTelefone.Text;
            fornecedor.cnpj = maskCnpj.Text;
            fornecedor.categoria = txtCategoria.Text;
            fornecedor.preco = Convert.ToDecimal(txtPreco.Text);



            if (txtId.Text == "")
            {
                txtId.Text = fornecedor.Salvar().ToString();
            }
            else
            {
                fornecedor.cod_fornecedor = Convert.ToInt32(txtId.Text);
                fornecedor.Atualizar();
            }

        }
    }
}

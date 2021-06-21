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
    public partial class frmCadastroProduto : Form
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {

            ClProduto produto = new ClProduto();
            produto.nome = txtnome.Text;
            produto.tipo = txttipo.Text;
            produto.valor = txtvalor.Text;
            produto.departamento = txtdepartamento.Text;
           

            if (txtid.Text == "")
            {
                txtid.Text = produto.Salvar().ToString();
            }
            else
            {
                produto.cod_produto = Convert.ToInt32(txtid.Text);
                produto.Atualizar();
            }
        }
    }
}

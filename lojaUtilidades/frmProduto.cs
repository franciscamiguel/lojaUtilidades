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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
            PesquisarProdutoDgv(-1);
        }
        private void PesquisarProdutoDgv(int id)
        {
            ClProduto pesquisarProduto = new ClProduto();
            dgvProduto.DataSource = pesquisarProduto.PesquisarProduto(id);
            dgvProduto.Columns[0].Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            ClProduto pesquisarProduto = new ClProduto();
            dgvProduto.DataSource = pesquisarProduto.PesquisarProduto(txtNome.Text);
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            frmCadastroProduto frm = new frmCadastroProduto();
            frm.Text = "Cadastro de Novo Produto";
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection linha = dgvProduto.SelectedRows;

            ClProduto produto = new ClProduto();
            produto.cod_produto = (int)linha[0].Cells[0].Value;
            produto.nome = linha[0].Cells[1].Value.ToString();
            produto.tipo = linha[0].Cells[2].Value.ToString();
            produto.valor = linha[0].Cells[3].Value.ToString();
            produto.departamento = linha[0].Cells[4].Value.ToString();



            using (var frm = new frmCadastroProduto())
            {
                frm.Text = "Editar o Produto" + produto.nome;
                frm.btnsalvar.Text = "Atualizar";
                frm.txtnome.Text = produto.nome;
                frm.txttipo.Text = produto.tipo;
                frm.txtvalor.Text = produto.valor;
                frm.txtdepartamento.Text = produto.departamento;


                frm.txtid.Text = produto.cod_produto.ToString();
                frm.ShowDialog();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection linhaselecionada = dgvProduto.SelectedRows;

            if (linhaselecionada.Count != 1)
            {
                MessageBox.Show("Selecionar uma linha do registro para ser removido.");
            }
            else
            {
                ClProduto deletarproduto = new ClProduto();
                deletarproduto.Deletar((int)(linhaselecionada[0].Cells[0].Value));
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

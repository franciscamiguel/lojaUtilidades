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
    public partial class frmFornecedor : Form
    {
        private object frm;

        public frmFornecedor()
        {
            InitializeComponent();
            PesquisarFornecedorDgv(-1);
        }
        private void PesquisarFornecedorDgv(int id)
        {
            ClFornecedor pesquisarFornecedor = new ClFornecedor();
           dgvFornecedor.DataSource = pesquisarFornecedor.PesquisarFornecedor(id);
           dgvFornecedor.Columns[0].Visible = false;
         
        }
        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            ClFornecedor pesquisarFornecedor = new ClFornecedor();
            dgvFornecedor.DataSource = pesquisarFornecedor.PesquisarFornecedor(txtNome.Text);
        }


        private void button2_Click(object sender, EventArgs e) //btao salvar
        {
            frmCadastroFornecedor frm = new frmCadastroFornecedor();
            frm.Text = "Cadastro de Novo Fornecedor";
            frm.ShowDialog();
            //PesquisarFornecedorDgv(Convert.ToInt32(frm.txtId.Text));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvFornecedor.SelectedRows;

            ClFornecedor fornecedor = new ClFornecedor();
            fornecedor.cod_fornecedor = (int)linha[0].Cells[0].Value;
            fornecedor.nome = linha[0].Cells[1].Value.ToString();
            fornecedor.cnpj = linha[0].Cells[2].Value.ToString();
            fornecedor.telefone = linha[0].Cells[3].Value.ToString();
            fornecedor.categoria = linha[0].Cells[4].Value.ToString();
            fornecedor.preco = (decimal)linha[0].Cells[5].Value;


            using (var frm = new frmCadastroFornecedor())
            {
                frm.Text = "Editar o Fornecedor" + fornecedor.nome;
                frm.btnSalvar.Text = "Atualizar";
                frm.txtNome.Text = fornecedor.nome;
                frm.maskCnpj.Text = fornecedor.cnpj;
                frm.maskTelefone.Text = fornecedor.telefone;
                frm.txtCategoria.Text = fornecedor.categoria;
                frm.txtPreco.Text = fornecedor.preco.ToString();

                frm.txtId.Text = fornecedor.cod_fornecedor.ToString();
                frm.ShowDialog();
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linhaselecionada = dgvFornecedor.SelectedRows;

            if (linhaselecionada.Count != 1)
            {
                MessageBox.Show("Selecionar uma linha do registro para ser removido.");
            }
            else
            {
                ClFornecedor deletarfornecedor = new ClFornecedor();
                deletarfornecedor.Deletar((int)(linhaselecionada[0].Cells[0].Value));
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNome_TextChanged_1(object sender, EventArgs e)
        {
            ClFornecedor pesquisarFornecedor = new ClFornecedor();
            dgvFornecedor.DataSource = pesquisarFornecedor.PesquisarFornecedor(txtNome.Text);
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection linha = dgvFornecedor.SelectedRows;

            ClFornecedor fornecedor = new ClFornecedor();
            fornecedor.cod_fornecedor = (int)linha[0].Cells[0].Value;
            fornecedor.nome = linha[0].Cells[1].Value.ToString();
            fornecedor.cnpj = linha[0].Cells[2].Value.ToString();
            fornecedor.telefone = linha[0].Cells[3].Value.ToString();
            fornecedor.categoria = linha[0].Cells[4].Value.ToString();
            fornecedor.preco = (decimal)linha[0].Cells[5].Value;


            using (var frm = new frmCadastroFornecedor())
            {
                frm.Text = "Editar o Fornecedor" + fornecedor.nome;
                frm.btnSalvar.Text = "Atualizar";
                frm.txtNome.Text = fornecedor.nome;
                frm.maskCnpj.Text = fornecedor.cnpj;
                frm.maskTelefone.Text = fornecedor.telefone;
                frm.txtCategoria.Text = fornecedor.categoria;
                frm.txtPreco.Text = fornecedor.preco.ToString();

                frm.txtId.Text = fornecedor.cod_fornecedor.ToString();
                frm.ShowDialog();
            }
        }
    }
}

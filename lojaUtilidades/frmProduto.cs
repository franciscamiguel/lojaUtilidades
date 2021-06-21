using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lojaUtilidades
{
    class frmProduto
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
        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            ClProduto pesquisarProduto = new ClProduto();
            dgvProduto.DataSource = pesquisarproduto.PesquisarProduto(txtNome.Text);
        }


        private void button2_Click(object sender, EventArgs e) //btao salvar
        {
            frmCadastroProduto frm = new frmCadastroProduto();
            frm.Text = "Cadastro de Novo Produto";
            frm.ShowDialog();
            //PesquisarFornecedorDgv(Convert.ToInt32(frm.txtId.Text));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvProduto.SelectedRows;

            ClProduto produto = new ClProduto();
            frmProduto.cod_produto = (int)linha[0].Cells[0].Value;
            frmProduto.nome = linha[0].Cells[1].Value.ToString();
            frmProduto.tipo = linha[0].Cells[2].Value.ToString();
            frmProduto.valor = linha[0].Cells[3].Value.ToString();
            frmProduto.departamento = linha[0].Cells[4].Value.ToString();



            using (var frm = new frmCadastroFornecedor())
            {
                frm.Text = "Editar o Produto" + produto.nome;
                frm.btnSalvar.Text = "Atualizar";
                frm.txtNome.Text = produto.nome;
                frm.txttipo.Text = produto.tipo;
                frm.txtvalor.Text = produto.valor;
                frm.txtDepartamento.Text = produto.departamento;
                

                frm.txtId.Text = produto.cod_Produto.ToString();
                frm.ShowDialog();
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNome_TextChanged_1(object sender, EventArgs e)
        {
            ClProduto pesquisarproduto = new ClProduto();
            dgvProduto.DataSource = pesquisarProduto.PesquisarProduto(txtNome.Text);
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection linha = dgvProduto.SelectedRows;

            ClProduto pesquisarproduto = new ClProduto();
            frmProduto.cod_fornecedor = (int)linha[0].Cells[0].Value;
            frmProduto.nome = linha[0].Cells[1].Value.ToString();
            frmProduto.tipo = linha[0].Cells[2].Value.ToString();
            frmProduto.valor = linha[0].Cells[3].Value.ToString();
            frmProduto.departamento = linha[0].Cells[4].Value.ToString();
            


            using (var frm = new frmCadastroFornecedor())
            {
                frm.Text = "Editar o Produto" + produto.nome;
                frm.btnSalvar.Text = "Atualizar";
                frm.txtNome.Text = produto.nome;
                frm.txttipo.Text = produto.tipo;
                frm.txtvalor.Text = produto.;valor
                frm.txtdeparmento.Text = produto.departamento;
              

                frm.txtId.Text = produto.cod_fornecedor.ToString();
                frm.ShowDialog();
            }
        }
    }
}

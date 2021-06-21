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
    public partial class fmCliente : Form
    {
        public fmCliente()
        {
            InitializeComponent();
            pesquisarClienteDgv(-1);
        }
         private void pesquisarClienteDgv(int id)
        {
            clCliente pesquisarCliente = new clCliente();
            dgvCliente.DataSource = pesquisarCliente.PesquisarCliente(id);
            dgvCliente.Columns[0].Visible = false;
            dgvCliente.Columns[5].Visible = false;
            dgvCliente.Columns[6].Visible = false;
            dgvCliente.Columns[7].Visible = false;
            dgvCliente.Columns[8].Visible = false;
            dgvCliente.Columns[9].Visible = false;
            dgvCliente.Columns[10].Visible = false;
        }
       

       

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            clCliente pesquisarCliente = new clCliente();
            dgvCliente.DataSource = pesquisarCliente.PesquisarCliente(txtNome.Text);
        }

        

        private void button2_Click(object sender, EventArgs e) //btao salvar
        {
            FrmClienteCadastro frm = new FrmClienteCadastro();
            frm.Text = "Cadastro de Novo Cliente";
            frm.ShowDialog();
            pesquisarClienteDgv(Convert.ToInt32(frm.txtId.Text));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvCliente.SelectedRows;

            clCliente cliente = new clCliente();
            cliente.cod_cliente = (int)linha[0].Cells[0].Value;
            cliente.nome = linha[0].Cells[1].Value.ToString();
            cliente.cpf = linha[0].Cells[2].Value.ToString();
            cliente.telefone = linha[0].Cells[3].Value.ToString();
            cliente.email = linha[0].Cells[4].Value.ToString();
            cliente.logrado = linha[0].Cells[5].Value.ToString();
            cliente.numero = linha[0].Cells[6].Value.ToString();
            cliente.bairro = linha[0].Cells[7].Value.ToString();
            cliente.cidade = linha[0].Cells[8].Value.ToString();
            cliente.estado = linha[0].Cells[9].Value.ToString();
            cliente.cep = linha[0].Cells[10].Value.ToString();

            using (var frm = new FrmClienteCadastro())
            {
                frm.Text = "Editar o Cliente" + cliente.nome;
                
                frm.txtNome.Text = cliente.nome;
                frm.txtCpf.Text = cliente.cpf;
                frm.txtTelefone.Text = cliente.telefone;
                frm.txtEmail.Text = cliente.email;
                frm.txtLogrado.Text = cliente.logrado;
                frm.txtNumero.Text = cliente.numero;
                frm.txtBairro.Text = cliente.bairro;
                frm.txtCidade.Text = cliente.cidade;
                frm.txtEstado.Text = cliente.estado;
                frm.txtCep.Text = cliente.cep;
                frm.txtId.Text = cliente.cod_cliente.ToString();
                frm.ShowDialog();



            }
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linhaselecionada = dgvCliente.SelectedRows;

            if (linhaselecionada.Count != 1)
            {
                MessageBox.Show("Selecionar uma linha do registro para ser removido.");
            }
            else
            {
                clCliente deletarcliente = new clCliente();
                deletarcliente.Deletar((int)(linhaselecionada[0].Cells[0].Value));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

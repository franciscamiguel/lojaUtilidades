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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            carregarVendedor();
        }

      private void carregarVendedor()
        {
            ClVendedor vendedor = new ClVendedor();
            cmbVendedor.DataSource = vendedor.PesquisarVendedor();
            cmbVendedor.DisplayMember = "nome";
            cmbVendedor.ValueMember = "cod_vendedor";
        }
        private void tsmNovoCliente_Click(object sender, EventArgs e)
        {
           fmCliente fm = new fmCliente();
            fm.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using ( var form = new FrmVendedor())
            {
                form.btnAdicionar.Text = "Adicionar";
                form.Text = "Cadastro de Vendedor";
                form.ShowDialog();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using ( var form = new FrmVendedor())
            {
                ClVendedor vendedor = new ClVendedor();
                vendedor.PesquisarVendedor((int)cmbVendedor.SelectedValue);

                form.Text = "Editar Vendedor";
                form.btnAdicionar.Text = "Editar";
                form.txtNome.Text = vendedor.nome;
                form.txtId.Text = vendedor.cod_vendedor.ToString();
                form.mskTelefone.Text = vendedor.telefone;
                form.chkAtivo.Checked = vendedor.situacao;
                form.ShowDialog();
                carregarVendedor();
            }
        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tsmNovoFornecedor_Click(object sender, EventArgs e)
        {
            using (var frm = new frmFornecedor())
            {
                frm.ShowDialog();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnproduto_Click(object sender, EventArgs e)
        {
            using (var frm = new frmProduto())
            {
                frm.ShowDialog();
            }
        }
    }
}

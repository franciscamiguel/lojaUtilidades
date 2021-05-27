using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lojaUtilidades
{
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            clCliente cliente = new clCliente();
            cliente.nome = txtNome.Text;
            cliente.bairro = txtBairro.Text;
            cliente.cep = txtCep.Text;
            cliente.cidade = txtCidade.Text;
            cliente.cpf = txtCpf.Text;
            cliente.email = txtEmail.Text;
            cliente.estado = txtEstado.Text;
            cliente.logrado = txtLogrado.Text;
            cliente.numero = txtNumero.Text;
            cliente.telefone = txtTelefone.Text;
           

            if (txtId.Text == "")
            {
                txtId.Text = cliente.Salvar().ToString();
            }
            else
            {
                cliente.cod_cliente = Convert.ToInt32(txtId.Text);
                cliente.Atualizar();
                    
            }
        }
        
    }
}

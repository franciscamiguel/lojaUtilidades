using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lojaUtilidades
{
    class ClFornecedor : conectaBD
    {
        public int cod_fornecedor { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public string telefone { get; set; }
        public string produto { get; set; }
        public string preco { get; set; }

       

        public int Salvar()
        {
            int id = 0;
            try
            {
              _sql = string.Format("INSERT INTO fornecedor (cod_fornecedor,nome, cnpj, telefone, produto, preco) VALUES ('{0}',  '{1}' '{2}' '{3}' '{4}' '{5}')" ,cod_fornecedor, nome, cnpj, telefone, produto, preco) + "; SElECT SCOPE_IDENTITY();";
            ExecutaComando(false, out id);

                if (id > 0)
                {
                    string cod = Convert.ToString(id);
                    MessageBox.Show(string.Format("fornecedorr cadastrado com sucesso!\nCódigo do fornecedor é {0}", cod), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar FORNECEDOR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message);
            }
            return id;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public DataTable PesquisarFornecedor(string nomeFornecedor)
        {
            try
            {
                _sql = string.Format("SELECT * FROM  WHERE nome LIKE '%{0}%'", nomeFornecedor);
                return ExecutaSelect();
            }
            catch (Exception)
            {

            }

            return null;
        }




        public DataTable PesquisarFornecedor(int id)
        {
            try
            {
                if (id < 0)
                {
                  _sql = "SELECT * FROM fornecedor ORDER BY nome";
                    return ExecutaSelect();
                }
                else
                {
                   _sql = string.Format("SELECT * FROM fornecedor  WHERE cod_fronecedor = {0}ORDER BY nome", id);
                    return ExecutaSelect();
                }


            }
            catch (Exception)
            {

            }

            return null;
        }
        public void Atualizar()
        {
            try
            {
                int exOK = 0;


                _sql = string.Format("UPDATE Fornecedor SET nome = '{0}',  telefone = '{1}' WHERE cod_vendedor = '{2}'", nome, telefone, cod_fornecedor);

                exOK = ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao atualizar fornecedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("fornecedor atualizado com sucesso", "Atualização com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Deletar(int id)
        {
            try
            {
                int exOK = 0;
               _sql = "DELETE FROM fornecedor where cOD_fornecedor = " + id;

                exOK = ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao apagar fornecedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("fornecedor apagado com sucesso", "fornecedor apagado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }   
}
    

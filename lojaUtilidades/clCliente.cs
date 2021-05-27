using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace lojaUtilidades
{
    public class clCliente
    {
        public int cod_cliente { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string logrado { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }

        conectaBD BancoDados = new conectaBD();

        public int Salvar()
        {
            int id = 0;
            try
            {
                BancoDados._sql = string.Format("INSERT INTO cliente(nome, cpf, telefone, email, logradouro, numero, bairro, cidade, estado, cep) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", nome, cpf, telefone, email, logrado, numero, bairro, cidade, estado, cep) + "; SElECT SCOPE_IDENTITY();";
                BancoDados.ExecutaComando(false, out id);

                if (id > 0)
                {
                    string cod = Convert.ToString(id);
                    MessageBox.Show(string.Format("cliente cadastrado com sucesso!\nCódigo do cliente é {0}", cod), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message);
            }
            return id;
        }
        public DataTable PesquisarCliente(string nomeCliente)
        {
            try
            {
                BancoDados._sql = string.Format("SELECT * FROM cliente WHERE nome LIKE '%{0}%'", nomeCliente);
                return BancoDados.ExecutaSelect();
            }
            catch (Exception)
            {

            }

            return null;
        }




        public DataTable PesquisarCliente(int id)
        {
            try
            {
                if (id < 0)
                {
                    BancoDados._sql = "SELECT * FROM cliente ORDER BY nome";
                    return BancoDados.ExecutaSelect();
                }
                else
                {
                    BancoDados._sql = string.Format("SELECT * FROM cliente  WHERE cod_cliente = {0}ORDER BY nome", id);
                    return BancoDados.ExecutaSelect();
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


                BancoDados._sql = string.Format("UPDATE cliente SET nome = '{0}', cpf = '{1}', telefone = '{2}', email = '{3}', logradouro = '{4}', numero = '{5}', bairro = '{6}', cidade = '{7}', estado = '{8}', cep = '{9}' WHERE cod_cliente = '{10}'", nome, cpf, telefone, email, logrado, numero, bairro, cidade, estado, cep, cod_cliente);

                exOK = BancoDados.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao atualizar cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("cliente atualizado conm sucesso", "Atualização com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                BancoDados._sql = "DELETE FROM cliente where cOD_CLIENTE = " + id;

                exOK = BancoDados.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao apagar cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("cliente apagado com sucesso", "cliente apagado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
             catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            

        }

    }
}


using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace lojaUtilidades
{
    class ClVendedor : conectaBD
    {

        public int cod_vendedor { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public bool situacao { get; set; }

        public int Salvar()
        {
            int id = 0;
            try
            {
                _sql = string.Format("INSERT INTO vendedor(nome, telefone ) VALUES ('{0}', '{1}')", nome, telefone) + "; SElECT SCOPE_IDENTITY();";
                ExecutaComando(false, out id);

                if (id > 0)
                {
                    string cod = Convert.ToString(id);
                    MessageBox.Show(string.Format("vendedor cadastrado com sucesso!\nCódigo do vendedor é {0}", cod), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar VENDEDOR");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message);
            }
            return id;

        }


        public DataTable PesquisarVendedor()
        {
            try
            {


                _sql = "SELECT * FROM vendedor ORDER BY nome";
                return ExecutaSelect();

            }
            catch (Exception)
            {

            }

            return null;

        }

        public void PesquisarVendedor(int id)
        {
            try
            {
                _sql = "SELECT * FROM vendedor WHERE cod_vendedor = " + id;
                executaselectfrom();

                if (Dr.Read())
                {
                    cod_vendedor = (int)Dr["cod_vendedor"];
                    nome = Dr["nome"].ToString();
                    telefone = Dr["telefone"].ToString();
                    situacao = (bool)Dr["situacao"];
                }
            }
            catch (Exception ex)
            {

                throw new Exception("erro ao onter dados: " + ex.Message);
            }
            finally
            {
                FechaConexao();
            }
        }
        public void Atualizar()
        {
            try
            {
                int exOK = 0;


                _sql = string.Format("UPDATE Vendedor SET nome = '{0}',  telefone = '{1}', situacao = '{2}' WHERE cod_vendedor = '{3}'", nome, telefone, cod_vendedor, situacao);

                exOK = ExecutaComando(false);

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
        public void AtualizarSituacao(int id)
        {
            try
            {
                int exOK = 0;

                _sql = "UPDATE vendedor SET situacao =  0 WHERE cod_vendedor = " + id;

                exOK = ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao atualizar cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cliente atualizado com sucesso", "Atualização com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}











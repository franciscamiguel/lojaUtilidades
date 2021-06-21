using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lojaUtilidades
{
    class ClProduto : conectaBD
    {
        private string _sql;

        public int cod_produto { get; set; }
        public string nome { get; set; }
        public string tipo { get; set; }
        public string valor { get; set; }
        public string departamento { get; set; }



        public int Salvar()
        {
            int id = 0;
            try
            {
                _sql = string.Format("INSERT INTO produtos(nome, tipo, valor, departamento) VALUES ('{0}', '{1}', '{2}', '{3}')", nome, tipo, valor, departamento) + "; SElECT SCOPE_IDENTITY();";
                ExecutaComando(false, out id);

                if (id > 0)
                {
                    string cod = Convert.ToString(id);
                    MessageBox.Show(string.Format("produto cadastrado com sucesso!\nCódigo do produto é {0}", cod), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar produto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message);
            }
            return id;
        }
        public DataTable PesquisarProduto(string nomeProduto)
        {
            try
            {
                _sql = string.Format("SELECT * FROM produtos WHERE nome LIKE '%{0}%'", nomeProduto);
                return ExecutaSelect();
            }
            catch (Exception)
            {

            }

            return null;
        }




        public DataTable PesquisarProduto(int id)
        {
            try
            {
                if (id < 0)
                {
                    _sql = "SELECT * FROM produtos ORDER BY nome";
                    return ExecutaSelect();
                }
                else
                {
                    _sql = string.Format("SELECT * FROM produtos  WHERE cod_produto = {0} ORDER BY nome", id);
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


                _sql = string.Format("UPDATE produtos SET nome = '{0}', tipo = '{1}', valor = '{2}', departamento = '{3}' WHERE cod_produto = '{4}'", nome, tipo, valor, departamento, cod_produto);

                exOK = ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao atualizar produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("produto atualizado conm sucesso", "Atualização com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                _sql = "DELETE FROM produtos where cOD_Produto = " + id;

                exOK = ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao apagar produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("produto apagado com sucesso", "cliente apagado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}

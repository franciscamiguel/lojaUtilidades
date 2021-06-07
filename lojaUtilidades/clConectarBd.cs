using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace lojaUtilidades
{
    class conectaBD
    {
        // Campo responsável pela definição da string de conexão
        protected string _strConexao;

        // Campo responsável pela definição da string do sql
        protected string _sql;

        // Campo responsável pelo comando de SQL a ser executado
        private SqlCommand _comandoSQL;

        //campo responsável pelo comando do SQL a ser executado
        protected SqlDataReader Dr;

        // Campo que define o objeto de conexão
        private SqlConnection _conexao;

        // Campo que define o objeto de transação
        private SqlTransaction _transacao;

        // Construtor que define uma string de conexão fixa e cria os objetos de conexão e comando
        protected conectaBD()
        {
                _strConexao = @"DATA SOURCE= .\SQLEXPRESS; Initial Catalog=Loja;Persist Security Info=True;User ID=sa;Password=francisca92";
          _conexao = new SqlConnection(_strConexao);
            _comandoSQL = new SqlCommand();
            _comandoSQL.Connection = _conexao;
        }

        // Método para abrir a conexão com o banco de dados
        // true -> Com transação | false -> Sem transação
        protected bool AbreConexao(bool transacao)
        {
            try
            {
                _conexao.Open();
                if (transacao)
                {
                    _transacao = _conexao.BeginTransaction();
                    _comandoSQL.Transaction = _transacao;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Métodos para fechar a conexão com o banco de dados
        //Retorna um booleano para indicar o resultado da operação
        protected bool FechaConexao()
        {
            try
            {
                if (_conexao.State == ConnectionState.Open)
                    _conexao.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Finaliza uma transação
        // true -> Executa o commit | false -. Executa o rollback
        protected void FinalizaTransacao(bool commit)
        {
            if (commit)
                _transacao.Commit();
            else
                _transacao.Rollback();
            FechaConexao();
        }

        // Destrutor que fecha a conexão com o banco de dados
        ~conectaBD()
        {
            FechaConexao();

        }

        // Método responsável pela execução dos comandos de Insert, Update e Delete
        //Retorna um número inteiro que indica a quantidade de linhas afetadas
        protected int ExecutaComando(bool transacao = false)
        {
            int retorno;
            AbreConexao(transacao);
            try
            {
                _comandoSQL.CommandText = _sql;
                retorno = _comandoSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
                return -1;
            }
            finally
            {
                if (!transacao)
                    FechaConexao();
            }
            return retorno;
        }

        //Método responsável pela execução dos comandos de Insert com retorno do último código cadastrado
        //Retorna um número inteiro que indica a quantidade de linhas afetadas
        protected int ExecutaComando(bool transacao, out int ultimoCodigo)
        {
            int retorno;
            ultimoCodigo = 0;
            AbreConexao(transacao);
            try
            {
                //Executa o comando de insert e já retorna o @@IDENTITY
                _comandoSQL.CommandText = _sql;
                ultimoCodigo = Convert.ToInt32(_comandoSQL.ExecuteScalar());
                retorno = 1;
            }
            catch
            {
                retorno = -1;
            }
            finally
            {
                if (!transacao)
                    FechaConexao();
            }
            return retorno;
        }

        //Método responsável pela execução dos comandos de Select
        //Retorna um DataTable com o resultado da operação
        protected DataTable ExecutaSelect()
        {
            AbreConexao(false);
            DataTable dt = new DataTable();
            try
            {
                _comandoSQL.CommandText = _sql;
                dt.Load(_comandoSQL.ExecuteReader());
            }
            catch
            {
                dt = null;
            }
            finally
            {
                FechaConexao();
            }
            return dt;
        }
        protected void executaselectfrom()
        {
            AbreConexao(false);

            try
            {
                _comandoSQL.CommandText = _sql;
                Dr = (_comandoSQL.ExecuteReader());
            }
            catch 
            {

                
            }
        }
        // Método que executa comandos de Select para retornos escalares, ou seja,
        // retorna a primeira linha e primeira coluna do resultado do comando de Select.
        // Para nosso exemplo, sempre convertemos esse valor para Double
        //Retorna a primeira linha e primeira coluna do resultado comando de Select</returns>
        protected double ExecutaScalar()
        {
            AbreConexao(false);
            double retorno;
            try
            {
                _comandoSQL.CommandText = _sql;
                retorno = Convert.ToDouble(_comandoSQL.ExecuteScalar());
            }
            catch
            {
                retorno = -1;
            }
            finally
            {
                FechaConexao();
            }
            return retorno;
        }

    }
}


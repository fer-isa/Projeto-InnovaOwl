using Aula_15_04.conexao;
using Aula_15_04.DTOs;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15_04.DAL
{
    internal class consultaProfessores
    {
        public static List<ProfessoresDTOs> ListarTodosOsProfessoresDTO()
        {
           // Instância da nossa classe de conexao
             Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = "SELECT tb_professores.id_professor, nome, email FROM tb_professores;";

            // Adaptador de rede do MySQL para realizar a conexão ao banco de dados
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, minhaConexao.Start());

            // Tente
            try
            {
                // Criar uma variavel do tipo tabela de dados (que é a isntância de uma classe)
                DataTable dataTable = new DataTable();
                // Preencher a tabela com o retorno da consulta do adaptador
                dataAdapter.Fill(dataTable);


                List<ProfessoresDTOs> listaDeProfessoresDTO = new List<ProfessoresDTOs>();

                // Preenchendo a lista com os valores recebidos do banco de dados
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    listaDeProfessoresDTO.Add(
                        new ProfessoresDTOs(
                            (int)dataTable.Rows[i]["id_professor"],
                            (string)dataTable.Rows[i]["nome"],
                            (string)dataTable.Rows[i]["email"]
                           

                        )
                    );
                }
                return listaDeProfessoresDTO;
            }
            // Em caso de erro
            catch (Exception error)
            {
                //captura o erro e mostra a mensagem
                throw new Exception(error.Message);
            }
            // Apos sucesso/erro 
            finally
            {
                // Chame a função de fechar a conexao do objeto minhaConexao
                minhaConexao.Close();
            }
        }

        public static DataTable ListarProfessores()
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = "SELECT * FROM tb_professores;";

            // Adaptador de rede do MySQL para realizar a conexão ao banco de dados
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, minhaConexao.Start());

            // Tente
            try
            {
                // Criar uma variavel do tipo tabela de dados (que é a isntância de uma classe)
                DataTable dataTable = new DataTable();
                // Preencher a tabela com o retorno da consulta do adaptador
                dataAdapter.Fill(dataTable);
                // Retornar o objeto dataTable preenchido
                return dataTable;
            }
            // Em caso de erro
            catch (Exception error)
            {
                //captura o erro e mostra a mensagem
                throw new Exception(error.Message);
            }
            // Apos sucesso/erro 
            finally
            {
                // Chame a função de fechar a conexao do objeto minhaConexao
                minhaConexao.Close();
            }
        }
        public static DataTable BuscarProfessores(string nome)
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = $"SELECT * FROM tb_professores WHERE nome LIKE '%{nome}%' ;";

            // Adaptador de rede do MySQL para realizar a conexão ao banco de dados
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, minhaConexao.Start());

            // Tente
            try
            {
                // Criar uma variavel do tipo tabela de dados (que é a isntância de uma classe)
                DataTable dataTable = new DataTable();
                // Preencher a tabela com o retorno da consulta do adaptador
                dataAdapter.Fill(dataTable);
                // Retornar o objeto dataTable preenchido
                return dataTable;
            }
            // Em caso de erro
            catch (Exception error)
            {
                //captura o erro e mostra a mensagem
                throw new Exception(error.Message);
            }
            // Apos sucesso/erro 
            finally
            {
                // Chame a função de fechar a conexao do objeto minhaConexao
                minhaConexao.Close();
            }
        }
        public static void AdicionarProfessores(string nome, string email)
        {
            Conexao minhaConexao = new Conexao();

            string query = @$"INSERT INTO tb_professores(nome, email) VALUES  
                ('{nome}', '{email}');";

            MySqlCommand mySqlCommand = new MySqlCommand(query, minhaConexao.Start());

            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            finally
            {
                minhaConexao.Close();
            }
        }
        public static void RemoverProfessores(int ID)
        {
            Conexao minhaConexao = new Conexao();

            string query = $"DELETE FROM tb_professores WHERE id_professor = {ID};";

            MySqlCommand mySqlCommand = new MySqlCommand(query, minhaConexao.Start());

            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            finally
            {
                minhaConexao.Close();
            }
        }

        public static void EditarProfessor(int id_ASerEditado, string nome, string email)
        {
            Conexao minhaConexao = new Conexao();

            string query = @$"UPDATE tb_professores SET  
                nome = '{nome}',
                email = '{email}'
                WHERE id_professor = {id_ASerEditado};";
                
              
            MySqlCommand mySqlCommand = new MySqlCommand(query, minhaConexao.Start());

            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            finally
            {
                minhaConexao.Close();
            }


        }


    }

}

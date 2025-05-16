using Aula_15_04.conexao;
using Aula_15_04.DTOs;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15_04.DAL
{
    public class ConsultaCursos
    {

        public static List<CursoDTOs> ListarTodosOsCursosDTO()
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = "SELECT tb_cursos.id_curso, tb_cursos.nome AS \"nome_curso\", tb_cursos.descricao, tb_cursos.carga_horaria, tb_professores.id_professor, tb_professores.nome AS \"nome_professor\", tb_categorias.id_categoria, tb_categorias.nome AS \"nome_categoria\", tb_cursos.link FROM tb_cursos INNER JOIN tb_professores ON tb_cursos.id_professor = tb_professores.id_professor INNER JOIN tb_categorias ON tb_cursos.id_categoria = tb_categorias.id_categoria;";

            // Adaptador de rede do MySQL para realizar a conexão ao banco de dados
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, minhaConexao.Start());

            // Tente
            try
            {
                // Criar uma variavel do tipo tabela de dados (que é a isntância de uma classe)
                DataTable dataTable = new DataTable();
                // Preencher a tabela com o retorno da consulta do adaptador
                dataAdapter.Fill(dataTable);
                List<CursoDTOs> listaDeCursosDTos = new List<CursoDTOs>();


                // Preenchendo a lista com os valores recebidos do banco de dados
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    listaDeCursosDTos.Add(
                        new CursoDTOs(
                            (int)dataTable.Rows[i]["id_curso"],
                            (string)dataTable.Rows[i]["nome_curso"],
                            (string)dataTable.Rows[i]["descricao"],
                            (int)dataTable.Rows[i]["carga_horaria"],
                            (string)dataTable.Rows[i]["link"],
                            (int)dataTable.Rows[i]["id_professor"],
                            (int)dataTable.Rows[i]["id_categoria"],
                            (string)dataTable.Rows[i]["nome_categoria"]

                        )
                    );
                }

                return listaDeCursosDTos;
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
        public static DataTable ListarCursos()
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = "SELECT * FROM tb_cursos;";

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


        public static DataTable BuscarCursos(string nome)
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = $"SELECT * FROM tb_cursos WHERE nome LIKE '%{nome}%' ;";

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

        public static void AdicionarCursos(string nome, string descricao, int cargaHoraria, string link, int id_professor, int id_categoria)
        {
            Conexao minhaConexao = new Conexao();

            string query = @$"INSERT INTO tb_cursos(nome, descricao, carga_horaria, link, id_professor, id_categoria) VALUES  
                ('{nome}', '{descricao}', {cargaHoraria}, '{link}', {id_professor}, {id_categoria});";



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


        public static void RemoverCursos(int ID)
        {
            Conexao minhaConexao = new Conexao();

            string query = $"DELETE FROM tb_cursos WHERE id_curso = {ID};";



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

        public static void EditarCurso(int id_ASerEditado,string nome, string descricao, int cargaHoraria, string link, int id_professor, int id_categoria)
        {
            Conexao minhaConexao = new Conexao();
             
            string query = @$"UPDATE tb_cursos SET  
                nome = '{nome}',
                descricao = '{descricao}',
                carga_horaria = {cargaHoraria}, 
                link = '{link}',
                id_professor = {id_professor}, 
                id_categoria = {id_categoria} WHERE id_curso = {id_ASerEditado};";
                


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

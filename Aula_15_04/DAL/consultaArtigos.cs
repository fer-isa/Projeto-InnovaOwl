using Aula_15_04.DTOs;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Aula_15_04.conexao
{
    internal class consultaArtigos
    {


        public static List<ArtigosDTOs> ListarTodosOsArtigosDTO()
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = @"SELECT a.id_artigo,
                a.titulo,
                a.subtitulo,
                a.descricao,
                a.data_publicacao,
                a.link_artigos,
                cat.id_categoria,
                cat.nome AS nome_categoria
                FROM 
                    tb_artigos a
                INNER JOIN 
                    tb_categorias cat ON a.id_categoria = cat.id_categoria;";

            // Adaptador de rede do MySQL para realizar a conexão ao banco de dados
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, minhaConexao.Start());

            // Tente
            try
            {
                // Criar uma variavel do tipo tabela de dados (que é a isntância de uma classe)
                DataTable dataTable = new DataTable();
                // Preencher a tabela com o retorno da consulta do adaptador
                dataAdapter.Fill(dataTable);

                List<ArtigosDTOs> listaDeArtigosDTOS = new List<ArtigosDTOs>();


                // Preenchendo a lista com os valores recebidos do banco de dados
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    listaDeArtigosDTOS.Add(
                        new ArtigosDTOs(
                            (int)dataTable.Rows[i]["id_artigo"],
                            (string)dataTable.Rows[i]["titulo"],
                            (string)dataTable.Rows[i]["subtitulo"],
                            (string)dataTable.Rows[i]["descricao"],
                            (string)dataTable.Rows[i]["link_artigos"],
                            (DateTime)dataTable.Rows[i]["data_publicacao"],
                            (int)dataTable.Rows[i]["id_categoria"],
                            (string)dataTable.Rows[i]["nome_categoria"]
                        )
                    );
                }

                return listaDeArtigosDTOS;
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


        public static DataTable listarArtigos()
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = "SELECT id_artigo, titulo, subtitulo, descricao, link_artigos, data_publicacao, id_categoria FROM tb_artigos;";

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


        public static DataTable buscarArtigos(string titulo)
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = $"SELECT * FROM tb_artigos WHERE titulo LIKE '%{titulo}%';";

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

        public static void AdicionarArtigos( string titulo, string subtitulo, string descricao, string link_artigos, string data_publicacao, int id_categoria)
        {
            Conexao minhaConexao = new Conexao();

            string query = @$"INSERT INTO tb_artigos (titulo, subtitulo, descricao, link_artigos, data_publicacao, id_categoria) VALUES 
                ('{titulo}', '{subtitulo}', '{descricao}', '{link_artigos}', '{data_publicacao}', {id_categoria});";




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
        public static void EditarArtigos(int id_artigo, string titulo, string subtitulo, string descricao, string link_artigos, string data_publicacao, int id_categoria)
        {
            Conexao minhaConexao = new Conexao();

            string query = @$"UPDATE tb_artigos SET 
               titulo = '{titulo}',  
               subtitulo = '{subtitulo}',
               descricao = '{descricao}', 
               link_artigos = '{link_artigos}',
               data_publicacao = '{data_publicacao}',
               id_categoria = {id_categoria}
               WHERE id_artigo = {id_artigo}";


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

        public static void RemoverArtigos(int ID)
        {
            Conexao minhaConexao = new Conexao();

            string query = $"DELETE FROM tb_artigos WHERE id_artigo = {ID}  ";



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

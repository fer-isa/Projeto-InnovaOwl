using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15_04.DTOs
{
    public class ArtigosDTOs
    {
        public int id { get; set; }

        public string titulo { get; set; }

        public string subtitulo { get; set; }

        public string descricao { get; set; }

        public string link_artigos { get; set; }

        public DateTime data_publicacao { get; set; }

        public int id_categoria { get; set; }

        public string nome_categoria { get; set; }

        public ArtigosDTOs(int id, string titulo, string subtitulo, string descricao, string link_artigos, DateTime data_publicacao, int id_categoria, string nome_categoria)
        {
            this.id = id;
            this.titulo = titulo;
            this.subtitulo = subtitulo;
            this.descricao = descricao;
            this.link_artigos = link_artigos;
            this.data_publicacao = data_publicacao;
            this.id_categoria = id_categoria;
            this.nome_categoria = nome_categoria;
        }
    }
}

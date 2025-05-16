using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15_04.DTOs
{
    public class CursoDTOs
    {
        public CursoDTOs(int id, string nome, string descricao, int carga_horaria, string link, int id_professor, int id_categoria, string nome_categoria)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.carga_horaria = carga_horaria;
            this.link = link;
            this.id_professor = id_professor;
            this.id_categoria = id_categoria;
            this.nome_categoria = nome_categoria;
        }

        public int id {  get; set; }
        
        public string nome { get; set; }

        public string descricao { get; set; }

        public int carga_horaria { get; set; }

        public string link { get; set; }

        public int id_professor { get; set; }

        public int id_categoria { get; set; }

        public string nome_categoria { get; set; }

       
    }

}

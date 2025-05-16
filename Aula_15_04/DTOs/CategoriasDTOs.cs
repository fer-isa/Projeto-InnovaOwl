using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15_04.DTOs
{
    internal class CategoriasDTOs
    {
        
        public int id {  get; set; }

        public string nome { get; set; }

        public CategoriasDTOs(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
    }

}

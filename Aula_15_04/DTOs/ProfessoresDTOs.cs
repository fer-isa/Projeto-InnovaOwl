using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15_04.DTOs
{
    internal class ProfessoresDTOs
    {
        public ProfessoresDTOs(int id, string nome, string email)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
        }

        public int id {  get; set; }

        public string nome { get; set; }

        public string email { get; set; }

       
    }

}

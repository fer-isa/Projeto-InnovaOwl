using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15_04.DTOs
{
    internal class UsuariosDTOs
    {

        public int id {  get; set; }

        public string nome { get; set; }

        public string email { get; set; }

        public string senha { get; set; }

        public string telefone { get; set; }

        public UsuariosDTOs(int id, string nome, string email, string senha, string telefone)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.telefone = telefone;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestaBurracha
{
    class Funcionario : Usuario
    {
        private string _função;
        private bool _ativo;
        public string Função { get => _função; set => _função = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }

        public Funcionario(string nome, string email, string cpf, string função)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Função = função;
            Ativo = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestaBurracha
{
    class Usuario
    {
        private string _nome;
        private string _cpf;
        private string _email;

        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Email { get => _email; set => _email = value; }
    }
}

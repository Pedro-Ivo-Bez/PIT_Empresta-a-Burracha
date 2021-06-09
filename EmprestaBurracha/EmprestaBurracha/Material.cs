using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestaBurracha
{
    class Material
    {
        private string _nome;
        private int _quantidade;
        public string Nome { get => _nome; set => _nome = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }

        public Material (string nome, int quantidade)
        {
            Nome = nome;
            Quantidade = quantidade;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestaBurracha
{
    class Emprestimo
    {
        private Material _material;
        private int _id;
        private int _quantidade;
        private DateTime _devolução;
        private Funcionario _funcionario;
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public DateTime Devolução { get => _devolução; set => _devolução = value; }
        public Material Material { get => _material; set => _material = value; }
        public Funcionario Funcionario { get => _funcionario; set => _funcionario = value; }
        public int Id { get => _id; set => _id = value; }

        public Emprestimo(Material m, int quantidade, DateTime devolução, Funcionario funcionario)
        {
            Material = m;
            Quantidade = quantidade;
            Devolução = devolução;
            Funcionario = funcionario;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestaBurracha
{
    class Console
    {
        public static List<Funcionario> Funcionarios = new List<Funcionario>();
        public static List<Material> Materiais = new List<Material>();
        public static List<Emprestimo> Emprestimos = new List<Emprestimo>();
        public static void AdicionarFuncionario(Funcionario f)
        {
            Funcionarios.Add(f);
        }
        public static void AdicionarMaterial(Material m)
        {
            m.Id = Materiais.Count + 1;
            Materiais.Add(m);
        }
        public static void AdicionarEmprestimo(Emprestimo e)
        {
            e.Id = Emprestimos.Count + 1;
            Emprestimos.Add(e);
        }
    }
}

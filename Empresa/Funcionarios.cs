using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Funcionarios
    {
        public string Nome;
        public int Idade;

        public virtual double Comissao()
        {
            return 5000;
        }
    }

}

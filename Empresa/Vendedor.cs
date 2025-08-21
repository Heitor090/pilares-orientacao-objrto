using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Vendedor : Funcionarios
    {
        public override double Comissao()
        {
            return base.Comissao() * 0.10;
        }
    }
}

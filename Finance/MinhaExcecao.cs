using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance
{
    internal class MinhaExcecao : Exception
    {
        public MinhaExcecao(string msg) : base(msg) { }
    }
}

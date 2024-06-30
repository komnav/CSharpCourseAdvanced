using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class BankClient : IQueuable
    {
        public int Number { get; set; }

        public decimal Price { get; set; }
    }
}

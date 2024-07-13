using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class PostgresdataBase : IDataBase
    {
        private readonly ILogger _logger;
        public PostgresdataBase(ILogger logger)
        {
            _logger = logger;
        }
        public void Save()
        {
            Console.WriteLine("Datas seved");
            _logger.Log("The operation was succesfully ");
        }
    }
}

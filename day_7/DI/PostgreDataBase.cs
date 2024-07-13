using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class PostgreDataBase:IDataBase
    {
        private readonly ILogger _logger;
        public PostgreDataBase(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            Console.WriteLine("Datas saved");
            _logger.Log("The operation was succesfully");
        }
    }
}

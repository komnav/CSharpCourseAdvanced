using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class EmailService : IMessageService
    {
        private readonly ILogger _logger;
        private readonly IDataBase _dataBase;
        public EmailService(ILogger logger, IDataBase dataBase)
        {
            _logger = logger;
            _dataBase = dataBase;
        }
        public void SendMessage(string message)
        {
            Console.WriteLine("Email - " + message);
            _dataBase.Save();
            _logger.Log("Message successfully sent");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class TelegramService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Telegram - " + message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace roteiro1.parte3
{
    public class MysqlConnection : IConnection
    {
        public void connect()
        {
            Console.WriteLine("Conectando com o MySQL");
        }
    }
}

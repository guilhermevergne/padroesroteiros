using System;
using System.Collections.Generic;
using System.Text;

namespace roteiro1.parte1
{
    public class ServicoQuarto
    {
        MysqlConnection connection;
        public ServicoQuarto()
        {
            connection = new MysqlConnection();
        }

        public void verificarQuarto()
        {
            connection.connect();
            Console.WriteLine("Lógica de negócio para o Serviço de Quarto");
        }
    }
}

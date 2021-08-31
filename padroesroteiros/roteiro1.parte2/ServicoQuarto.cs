using System;
using System.Collections.Generic;
using System.Text;

namespace roteiro1.parte2
{
    public class ServicoQuarto
    {
        OracleConnection connection;
        public ServicoQuarto()
        {
            connection = new OracleConnection();
        }

        public void verificarQuarto()
        {
            connection.connect();
            Console.WriteLine("Lógica de negócio para o Serviço de Quarto");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace roteiro1.parte3
{
    public class ServicoQuarto
    {
        IConnection connection;
        public ServicoQuarto(IConnection c)
        {
            connection = c;
        }

        public void verificarQuarto()
        {
            connection.connect();
            Console.WriteLine("Lógica de negócio para o Serviço de Quarto");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace roteiro1.parte3
{
    public class RelatorioReserva
    {
        IConnection connection;
        public RelatorioReserva(IConnection c)
        {
            connection = c;
        }

        public void gerarRelatorio()
        {
            connection.connect();
            Console.WriteLine("Lógica de negócio para geração do relatório");
        }
    }
}

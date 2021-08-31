using System;
using System.Collections.Generic;
using System.Text;

namespace roteiro1.parte2
{
    public class RelatorioReserva
    {
        OracleConnection connection;
        public RelatorioReserva()
        {
            connection = new OracleConnection();
        }

        public void gerarRelatorio()
        {
            connection.connect();
            Console.WriteLine("Lógica de negócio para geração do relatório");
        }
    }
}

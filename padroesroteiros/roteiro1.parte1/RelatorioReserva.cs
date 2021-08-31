using System;
using System.Collections.Generic;
using System.Text;

namespace roteiro1.parte1
{
    public class RelatorioReserva
    {
        MysqlConnection connection;
        public RelatorioReserva()
        {
            connection = new MysqlConnection();
        }

        public void gerarRelatorio()
        {
            connection.connect();
            Console.WriteLine("Lógica de negócio para geração do relatório");
        }
    }
}

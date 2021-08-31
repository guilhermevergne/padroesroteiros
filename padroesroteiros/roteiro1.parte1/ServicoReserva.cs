using System;
using System.Collections.Generic;
using System.Text;

namespace roteiro1.parte1
{
    public class ServicoReserva
    {
        MysqlConnection connection;
        public ServicoReserva()
        {
            connection = new MysqlConnection();
        }
        public void criarReserva()
        {
            connection.connect();
            Console.WriteLine("Lógica de negócio para Reserva do Quarto");
        }
    }
}

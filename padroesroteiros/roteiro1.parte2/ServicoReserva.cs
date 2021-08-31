using System;
using System.Collections.Generic;
using System.Text;

namespace roteiro1.parte2
{
    public class ServicoReserva
    {
        OracleConnection connection;
        public ServicoReserva()
        {
            connection = new OracleConnection();
        }
        public void criarReserva()
        {
            connection.connect();
            Console.WriteLine("Lógica de negócio para Reserva do Quarto");
        }
    }
}

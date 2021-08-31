using System;
using System.Collections.Generic;
using System.Text;

namespace roteiro1.parte3
{
    public class ServicoReserva
    {
        IConnection connection;
        public ServicoReserva(IConnection c)
        {
            connection = c;
        }
        public void criarReserva()
        {
            connection.connect();
            Console.WriteLine("Lógica de negócio para Reserva do Quarto");
        }
    }
}

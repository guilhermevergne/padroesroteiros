using System;
using System.Collections.Generic;
using System.Text;

namespace roteiro1.parte3
{
    public class TesteConexão
    {
        public static void main(string[] args)
        {
            IConnection c = new MysqlConnection();
            ServicoQuarto quarto = new ServicoQuarto(c);
            quarto.verificarQuarto();

            ServicoReserva reserva = new ServicoReserva(c);
            reserva.criarReserva();

            RelatorioReserva relatorio = new RelatorioReserva(c);
            relatorio.gerarRelatorio();
        }
    }
}

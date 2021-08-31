using System;
using System.Collections.Generic;
using System.Text;

namespace roteiro1.parte2
{
    public class TesteConexão
    {
        public static void main(string[] args)
        {
            ServicoQuarto quarto = new ServicoQuarto();
            quarto.verificarQuarto();

            ServicoReserva reserva = new ServicoReserva();
            reserva.criarReserva();

            RelatorioReserva relatorio = new RelatorioReserva();
            relatorio.gerarRelatorio();
        }
    }
}

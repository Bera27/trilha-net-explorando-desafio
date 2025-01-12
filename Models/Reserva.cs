namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Feito!
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Feito!
                throw new Exception("Erro! A capacidade da suíte é menor que o número de hóspedes recebido.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Feito!
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Feito!
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;

            // Feito!
            if (DiasReservados >= 10)
            {
                valor = valor - (valor * 0.1M);
            }

            return valor;
        }
    }
}
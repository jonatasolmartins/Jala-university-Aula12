namespace Jala_university_Aula12.Bad
{
    internal class PagamentoSystemBad : IPagamentoBad
    {
       
        public bool EfetuarPagemento(BoletoBad boleto)
        {
            Console.WriteLine($"Pagamento processado: {boleto.Codigo}");
            return true;
        }

        public void ValidarCodigo(BoletoBad boleto)
        {
            if (string.IsNullOrEmpty(boleto.Codigo))
            {
                Console.WriteLine("Boleto invalido");
            }

            Console.WriteLine("Boleto Valido");
        }

        public BoletoBad GerarBoleto()
        {
            return new BoletoBad(Guid.NewGuid().ToString());
        }

        public bool ValidarDate(BoletoBad boleto)
        {
            Console.WriteLine($"Boleto dentro do prazo: {boleto.DataCriado}");
            return true;
        }

    }
}

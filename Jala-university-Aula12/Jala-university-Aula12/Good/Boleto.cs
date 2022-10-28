namespace Jala_university_Aula12.Good
{
    internal class Boleto : IPagamento, IBoleto
    {
        public string Codigo { get; set; }
        public DateTime DataVencimento { get; set; }

        public Boleto(string codigo)
        {
            Codigo = codigo;
        }

        public void ValidarCodigo(string codigo)
        {
            if (string.IsNullOrEmpty(Codigo))
            {
                Console.WriteLine("Boleto invalido");
            }

            Console.WriteLine("Boleto Valido");
        }

        public bool ValidarDate()
        {
            Console.WriteLine("Boleto dentro do prazo");
            return true;
        }

        public override string ToString()
        {
            return $"Boleto#{Codigo}";
        }
    }
}

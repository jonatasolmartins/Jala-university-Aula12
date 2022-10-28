namespace Jala_university_Aula12.Good
{
    internal class Pix : IPagamento
    {
        public string Codigo { get; set; }
        public Pix()
        {
            Codigo = Guid.NewGuid().ToString();
        }

        public void ValidarCodigo(string codigo)
        {
            Console.WriteLine($"Codigo valido:{codigo}");
        }

        public override string ToString()
        {
            return $"Pix#{Codigo}";
        }

    }
}

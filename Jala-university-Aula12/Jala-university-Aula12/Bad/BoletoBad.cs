namespace Jala_university_Aula12.Bad
{
    internal class BoletoBad
    {
        public string Codigo { get; set; }

        public DateTime DataCriado { get; set; } = DateTime.Now;

        public BoletoBad(string codigo)
        {
            Codigo = codigo;
        }

    }
}

namespace Jala_university_Aula12
{
    internal interface IPagamento
    {
        public string Codigo { get; set; }

        public void ValidarCodigo(string codigo);

    }

    public interface IBoleto
    {
        public bool ValidarDate();
    }
}

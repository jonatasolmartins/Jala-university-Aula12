namespace Jala_university_Aula12.Good
{
    internal static class BoletoExtension
    {
        public static Boleto GerarBoleto()
        {
            return new Boleto(Guid.NewGuid().ToString());
        }
    }
}

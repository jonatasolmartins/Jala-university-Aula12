namespace Jala_university_Aula12.Bad
{
    internal interface IPagamentoBad
    {
        public void ValidarCodigo(BoletoBad boleto);

        public bool ValidarDate(BoletoBad boleto);
    }
}

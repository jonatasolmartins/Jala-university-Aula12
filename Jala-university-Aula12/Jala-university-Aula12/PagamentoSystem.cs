namespace Jala_university_Aula12
{
    internal class PagamentoSystem
    {
        public bool EfetuarPagemento(IPagamento pagamento)
        {
            Console.WriteLine($"Pagamento processado: {pagamento.ToString()}");
            return true;
        }
    }
}

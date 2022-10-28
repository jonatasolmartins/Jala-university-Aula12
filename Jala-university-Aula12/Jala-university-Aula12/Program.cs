using Jala_university_Aula12;

var boleto = BoletoExtension.GerarBoleto();
Console.WriteLine($"Boleto gerado com sucesso: {boleto.Codigo}");

var pix = new Pix();
Console.WriteLine($"Pix gerado com sucesso: {pix.Codigo}");

var pagamento = new PagamentoSystem();
boleto.ValidarDate();
pagamento.EfetuarPagemento(boleto);

pagamento.EfetuarPagemento(pix);

Console.ReadLine();
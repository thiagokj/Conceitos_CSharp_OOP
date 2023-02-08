namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            ExemploComUsingEDispose();

        }

        private static void ExemploComUsingEDispose()
        {
            Console.Clear();

            // a instrução using garante o descarte ao término da execução,
            // independente de exceções.
            using (var pagamentoComDispose = new PagamentoComDispose())
            {
                Console.WriteLine("Processando pagamento...");
            }
        }

        private static void ExecutaExemplos()
        {
            Console.Clear();
            var pagamento = new Pagamento(DateTime.Now);
            var endereco = new Endereco();
            endereco.cep = "93443-111";

            //Exemplo aplicando herança
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Vencimento = DateTime.Now;
            pagamentoBoleto.EnderecoDeCobranca = endereco;
            pagamentoBoleto.NumeroBoleto = "23123333";
            pagamentoBoleto.Pagar();

            // Exemplo aplicando sobrescrita do método ToString()
            Console.WriteLine($"Data de vencimento: {pagamento.ToString()}");
            Console.WriteLine("");

            // Exemplo get e set das propriedades
            pagamento.DataPagamento = new DateTime(2020, 07, 02);
            var getPagamento = pagamento.DataPagamento;
            Console.WriteLine("");

            // Outro exemplo sobreescrita de métodos
            pagamento.Pagar();

            var pagamentoCartaoDeCredito = new PagamentoCartaoDeDebito(new DateTime(2023, 11, 22));
            pagamentoCartaoDeCredito.Pagar();
        }
    }
}
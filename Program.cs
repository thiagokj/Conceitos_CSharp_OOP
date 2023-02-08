namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            ExemploDeComparacaoDeObjetos();

        }

        private static void ExemploDeComparacaoDeObjetos()
        {
            Console.Clear();
            var pessoa1 = new PessoaCompara(1, "Thiago");
            var pessoa2 = new PessoaCompara(1, "Thiago");

            var comparacao = (pessoa1 == pessoa2);
            Console.WriteLine($"As pessoas são iguais (endereço memoria)? R: {comparacao}");

            var comparacaoComEquals = (pessoa1.Equals(pessoa2));
            Console.WriteLine($"As pessoas são iguais (equals)? R: {comparacaoComEquals}");
        }

        private static void ExemploUpcastEDowncast()
        {
            Console.Clear();
            var pessoa1 = new Pessoa();
            var pessoa2 = new Pessoa();
            var pessoaFisica = new PessoaFisica();
            var pessoaJuridica = new PessoaJuridica();

            //Upcast
            pessoa1 = pessoaFisica;

            //Downcast - faz de/para dos objetos e algumas propriedades podem ser perdidas.
            pessoaJuridica = (pessoa2 as PessoaJuridica) ?? new PessoaJuridica();

        }

        private static void ExemploComInterfaceEClasseAbstrata()
        {
            var pagamento = new PagamentoComPix();
            pagamento.Vencimento = DateTime.Now;
            pagamento.Pagar(25.90);
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
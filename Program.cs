using Conceitos_CSharp_OOP.Handlers;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionsHandler.ManipulandoExcecoes();
        }

        private static void ExemploDeConversaoDeListas()
        {
            Console.Clear();

            var pagamentos = new List<Pagamento>();
            pagamentos.Add(new Pagamento(89));
            pagamentos.Add(new Pagamento(421));
            pagamentos.Add(new Pagamento(143));
            pagamentos.Add(new Pagamento(314));
            pagamentos.Add(new Pagamento(995));

            // Converte List para IEnumerable
            var listaIEnumerable = pagamentos.AsEnumerable();

            // Converte IEnumerable para uma lista
            var listaDePagamentos = listaIEnumerable.ToList();

            // Converte para estrutura de dados mais primitiva, o array.
            var arrayPagamentos = listaDePagamentos.ToArray();
            Console.WriteLine($"Lista convertida em array. Exibindo o Id na posição 0: {arrayPagamentos[0].Id}");
        }
        private static void ExemplosComListas()
        {
            Console.Clear();
            // Cria uma lista de Pagamentos
            var pagamentos = new List<Pagamento>();

            // Adiciona pagamentos na lista, informando o Id.
            pagamentos.Add(new Pagamento(1));
            pagamentos.Add(new Pagamento(2));
            pagamentos.Add(new Pagamento(3));
            pagamentos.Add(new Pagamento(4));
            pagamentos.Add(new Pagamento(5));

            Console.WriteLine("");
            Console.WriteLine("Id's dos pagamentos adicionados a lista:");
            foreach (var pagamento in pagamentos)
            {
                Console.WriteLine(pagamento.Id);
            }
            Console.WriteLine("");

            var pagamentosRealizados = new List<Pagamento>();
            // Adiciona uma lista dentro de outra lista
            pagamentosRealizados.AddRange(pagamentos);
            Console.WriteLine("Id's dos pagamentos dentro da lista de pagamentos realizados:");
            foreach (var pagamento in pagamentosRealizados)
            {
                Console.WriteLine(pagamento.Id);
            }
            Console.WriteLine("");

            /** Utilizando os métodos First, Where e Find,
            **  Acessamos outro namespace chamado LINQ
            **  LINQ | Linguagem de Query Integrada.
            **  Com o LINQ podemos de fato fazer consultas nas listas
            **/

            // Retorna o primeiro elemento da lista com o metodo First
            var procuraPagamento = pagamentos.First();
            Console.WriteLine($"Primeiro Id de pagamento: {procuraPagamento.Id}");
            Console.WriteLine("");

            // Retorna somente o primeiro elemento da lista 
            // encontrado com o metodo First, onde o Id é igual a 3.
            var pagamentoFiltradoComFirst = pagamentos.First(x => x.Id == 3);
            Console.WriteLine($"Resultado da consulta utilizando First por Id: {pagamentoFiltradoComFirst.Id}");
            Console.WriteLine("");

            // Retorna uma lista de IEnumerable com os elementos encontrados,
            // onde o Id é igual a 3.
            var consultaPagamentoComWhere = pagamentos.Where(x => x.Id == 3);
            foreach (var item in consultaPagamentoComWhere)
            {
                Console.WriteLine($"Id do item retornado usando Where: {item.Id}");
            }
            Console.WriteLine("");

            // Retorna somente um elemento da lista 
            // com o metodo First, onde o Id é igual a 4.
            var consultaPagamentoComFind = pagamentos.Find(x => x.Id == 4);
            Console.WriteLine($"Id do item retornado usando Find: {consultaPagamentoComFind.Id}");

            // Remove um pagamento da lista
            pagamentos.Remove(pagamentoFiltradoComFirst);
            Console.WriteLine("");
            Console.WriteLine("Lista de pagamentos após remoção do Id 3:");
            foreach (var pagamento in pagamentos)
            {
                Console.WriteLine(pagamento.Id);
            }
            Console.WriteLine("");

            // Retorna verdadeiro ou falso
            var existePagamento = pagamentos.Any(x => x.Id == 3);
            Console.WriteLine($"Existe pagamento com o Id 3?: {existePagamento}");
            Console.WriteLine("");

            // Retorna a contagem de itens na lista conforme filtro
            var contaPagamento = pagamentos.Count(x => x.Id == 2);
            Console.WriteLine($"Quantidade de pagamentos com Id = 2: {contaPagamento}");
            Console.WriteLine("");

            // Laço com filtro FirstOrDefault.
            // Caso não encontre, retorna nulo.
            // Usando somente o First, retorna exceção em caso de erro.
            var pagamentoFirstOrDefault = pagamentos.FirstOrDefault(x => x.Id == 6);
            if (pagamentoFirstOrDefault != null)
            {
                Console.WriteLine($"Retorno do pagamento FirstOrDefault para Id 6: {pagamentoFirstOrDefault.Id}");
            }
            else
            {
                Console.WriteLine("Id 6 não encontrado na lista.");
            }
            Console.WriteLine("");

            // Fazendo paginação utilizando Skip e Take 
            pagamentos.Add(new Pagamento(3));
            Console.WriteLine($"Gerada nova lista:");
            foreach (var item in pagamentos)
            {
                Console.WriteLine($"Id {item.Id}");
            }
            Console.WriteLine("");
            Console.WriteLine($"Lista com paginação pulando o 1º item e pegando os próximos 2:");
            foreach (var item in pagamentos.Skip(1).Take(2))
            {
                Console.WriteLine($"Id {item.Id}");
            }
            Console.WriteLine("");

            // Limpa toda a lista
            pagamentos.Clear();
        }

        private static void ExemploComTiposDeListas()
        {
            // Cria uma lista do tipo IEnumerable que aceita objetos do tipo Pagamento
            // Esse tipo de lista possui métodos mais restritos, praticamente somente leitura.
            IEnumerable<Pagamento> pagamentosEnum = new List<Pagamento>();
            pagamentosEnum.GetEnumerator();

            // Cria uma lista do tipo primitivo string que aceita strings.
            // Esse tipo de lista é menos restrita que IEnumerable 
            // e pertime uma coleção de objetos de forma genérica
            ICollection<string> colecao = new List<string>();
            colecao.Count();

            // Cria uma lista que aceita objetos do tipo Pagamento
            // Lista sem restrições de métodos como:
            // adicionar, remover e demais manipulações com objetos
            var pagamentos = new List<Pagamento>();
            pagamentos.Add(new Pagamento());
            pagamentos.Remove(new Pagamento());
        }

        private static void ExemploComGenerics()
        {
            var pessoa = new PessoaGenerica();
            var pagamento = new PagamentoGenerico();
            var inscricao = new InscricaoGenerica();

            var contexto = new ContextoDeDados<IPessoa, PagamentoGenerico, InscricaoGenerica>();
            contexto.Salvar(pessoa);
            contexto.Salvar(pagamento);
            contexto.Salvar(inscricao);
        }

        private static void ExemploComEventos()
        {
            Console.Clear();

            var sala = new Sala(3);
            sala.EventoSalaEsgotada += AoEsgotar;
            sala.ReservaAssento();
            sala.ReservaAssento();
            sala.ReservaAssento();
            sala.ReservaAssento();
            sala.ReservaAssento();
            sala.ReservaAssento();
        }

        // Método delegado
        static void AoEsgotar(object sender, EventArgs e)
        {
            Console.WriteLine("Sala lotada");
        }

        private static void ExemploComDelegates()
        {
            Console.Clear();
            var pagar = new PagamentoDelegates.Pagar(RealizaPagamento);
            pagar(25);
        }

        public static void RealizaPagamento(double valor)
        {
            Console.WriteLine($"Valor pago: {valor}");
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
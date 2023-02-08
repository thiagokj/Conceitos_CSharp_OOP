namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var pagamento = new Pagamento(DateTime.Now);
            //pagamento.Vencimento = DateTime.Now;

            //Exemplo aplicando herança
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Vencimento = DateTime.Now;
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

    // 1. Encapsulamento | Organização e agrupamento das informações, por classes.
    class Pagamento
    {
        // Os modificadores de acesso definem a acessibilidade.
        /*
        * private | o acesso é limitado à classe
        * protected | o acesso é limitado à classe e as classes herdeiras
        * internal | o acesso é limitado ao assembly atual (pouco utilização)
        * public | o acesso não é restrito.
        */

        // Variáveis | não possuem métodos acessores e podem armazenar os valores das propriedades.
        // Padrão de escrita para variavel privada começa com underline,
        // podendo mudar conforme notação de cada projeto.
        private int _contador = 0;

        // Propriedades | Possuem métodos acessores, atribuindo ou recebendo valores.
        // Criação com atalho props. 
        // Essa é a forma otimizada e mais simples para usar os métodos acessores.
        public DateTime Vencimento { get; set; }

        // Criação com atalho propfull. 
        // Forma mais antiga para usar os métodos acessores.
        private DateTime _dataPagamento;

        public DateTime DataPagamento
        {
            get
            {
                // Podem ser feitas alterações antes do retorno
                Console.WriteLine($"Lendo o valor: {_dataPagamento.ToShortDateString()}");
                return _dataPagamento;
            }
            set
            {
                // Podem ser feitas formatações antes da atribuição
                // value é uma palavra reservada e sempre contem o valor
                // que foi informado.
                Console.WriteLine($"Atribuindo valor: {value}");
                _dataPagamento = value;
            }
        }

        protected Endereco? EnderecoDeCobranca;

        // Métodos | Também chamados de funções, trazem recursos adicionais como:

        // Construtor | Método especial com mesmo nome da classe, que não retorna valores.
        // Utilizado para inicializar um objeto/instância da classe.
        // Ele sempre é chamado através da palavra reservada new. Ex: new Pagamento();
        // atalho ctor
        public Pagamento()
        {
            Console.WriteLine("Iniciando pagamento");
            Console.WriteLine("");
        }

        // exemplo preenchendo variáveis
        public Pagamento(DateTime vencimento)
        {
            Console.WriteLine("Iniciando pagamento com a data de vencimento");
            DataPagamento = DateTime.Now;
        }

        // Sobrecarga | mesmo nome, com assinaturas diferentes.
        public void Pagar(int id) { }
        public void Pagar(int id, string pagador) { }

        // Sobrescrita | a palavra reservada virtual permite
        // sobrescrever via herança para classe filha.
        // Na classe filha, é usada palavra reservada override.
        public virtual void Pagar()
        {
            ConsultaSaldo();
        }

        // 2. Abstração | Método protegido, evita problemas de exposição de informações.
        private void ConsultaSaldo()
        {
            Console.WriteLine("Saldo do Cartão de Crédito: R$ 1212,99");
        }

        // Toda classe do .NET herda da classe raíz System.
        // System tem o método virtual ToString(), que permite a sobreescrita.
        public override string ToString()
        {
            return Vencimento.ToString("dd/MM/yyyy");
        }
    }

    // Toda nova classe criada é um tipo complexo.
    // Ao invés de criar +30 propriedades primitivas (int, string, char) em uma classe,
    // É uma melhor prática abstrair e organizar a informação em uma nova classe.
    class Endereco
    {
        // A interrogação informa que a variável pode ser nula.
        string? cep;
    }

    // 3. Herança | Facilita o reaproveitamento de código,
    // extendendo as funcionalidades de uma classe para outra.
    class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto = "";

        // 4. Polimorfismo | Permite alteração e sobrescrita do método por outra classe
        // que estiver implementando.
        public override void Pagar()
        {
            Console.WriteLine("Valor do boleto pago: R$ 26,11");
        }
    }

    class PagamentoCartaoDeDebito : Pagamento
    {
        //Construtor herdando parametros da classe pai
        public PagamentoCartaoDeDebito(DateTime vencimento) : base(vencimento)
        {
            Console.WriteLine($"Iniciando pagamento no débito com vencimento em: {vencimento}");
        }

        public string NumeroDoCartao = "";

        public override void Pagar()
        {
            // a palavra reservada base chama o método pai.
            base.Pagar();
            Console.WriteLine("Valor cobrado no Cartão de Débito: R$ 100,23");
        }
    }


}
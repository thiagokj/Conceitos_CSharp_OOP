namespace Payments
{

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
        // Criação com atalho prop. 
        // Essa é a forma otimizada e mais simples para usar os métodos acessores.
        public DateTime Vencimento { get; set; }

        public int Id { get; set; }

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

        protected internal Endereco? EnderecoDeCobranca { get; set; }

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
        public Pagamento(int id)
        {
            Console.WriteLine($"Gerado pagamento com o id {id}.");
            Id = id;
        }
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
}
/*
    Utilizando a palavra partial na declaração da classe,
    podemos segmentar o codigo para organização em arquivos
    separados. Esse tipo de instrução é muito usado em codigos
    mais antigos do ASP.NET
*/


namespace PagamentoParcial
{
    public partial class Pagamento
    {
        public int Propriedade2 { get; set; }
    }
}
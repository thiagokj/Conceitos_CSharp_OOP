/*
    var pessoa1 = new PessoaCompara(1, "Thiago");
    var pessoa2 = new PessoaCompara(1, "Thiago");

    // a comparação retorna false,
    // pois os objetos tem as mesmas propriedades,
    // mas estão em endereços de memória diferentes.
    var comparacao = (pessoa1 == pessoa2);
    Console.WriteLine($"As pessoas são iguais? R: {comparacao}");

    Para comparação em tipos primitivos, não haveria problema.
    Comparando propriedades individuais daria certo:

    var comparacao = (pessoa1.Id == pessoa2.Id);

    A forma mais correta é implementar a interface IEquatable<Tipo>
    Dessa maneira, é possivel comparar os objetos com a chamada do método Equals.
*/

namespace Payments
{
    class PessoaCompara : IEquatable<PessoaCompara>
    {

        public PessoaCompara(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public bool Equals(PessoaCompara? pessoa)
        {
            return Id == pessoa.Id;
        }
    }
}
namespace Payments
{


    // Toda nova classe criada é um tipo complexo.
    // Ao invés de criar +30 propriedades primitivas (int, string, char) em uma classe,
    // É uma melhor prática abstrair e organizar a informação em uma nova classe.
    public class Endereco
    {
        // A interrogação informa que a variável pode ser nula.
        public string? cep;
    }
}
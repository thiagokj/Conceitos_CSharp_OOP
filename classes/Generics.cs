/*
    Generics | Declaramos a classe como um tipo genérico,
    evitando criar métodos repetidos.

    Para definição usamos <Tipo>. Usando as melhores praticas,
    declaramos apenas <T>.

    class DataContext<T>
    {
        public void Save(T entity) { }
    }

    Dessa forma, validamos o tipo do objeto antes de executar ações.

    var context = new DataContext<Person>();
    context.Save(person);

*/

namespace Payments
{
    // Classe genérica
    // Utilize where para associar os tipos de objetos
    class ContextoDeDados<P, PA, I>
        where P : IPessoa
        where PA : PagamentoGenerico
        where I : InscricaoGenerica
    {
        public void Salvar(P entidade) { }
        public void Salvar(PA entidade) { }
        public void Salvar(I entidade) { }
    }

    class PessoaGenerica : IPessoa
    {

    }

    class PagamentoGenerico
    {

    }

    class InscricaoGenerica
    {

    }

    interface IPessoa
    {

    }
}
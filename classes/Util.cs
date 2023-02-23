namespace ManipulandoDatas
{
    public static class Util
    {
        public static string PrimeiraLetraMaiuscula(string texto)
        {
            return texto = string.Concat(texto[0].ToString().ToUpper(), texto.AsSpan(1));
        }

        public static void VerificaQualDataEMaior(DateTime dataInformada, DateTime dataAtual)
        {
            if (dataInformada > dataAtual)
            {
                Console.WriteLine($"{dataInformada.ToShortDateString()} é maior que {dataAtual.ToShortDateString()}");
            }
            else
            {
                Console.WriteLine($"{dataInformada.ToShortDateString()} é menor que {dataAtual.ToShortDateString()}");
            }
        }

        public static bool EFimDeSemana(DayOfWeek hoje)
        {
            return hoje == DayOfWeek.Saturday || hoje == DayOfWeek.Sunday;
        }
    }

}
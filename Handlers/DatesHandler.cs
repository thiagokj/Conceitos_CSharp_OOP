using System.Globalization;

namespace ManipulandoDatas;

public static class DatesHandler
{
    public static void ExibeDatasNoTerminal()
    {
        Console.Clear();

        var data = new DateTime();
        Console.WriteLine($"Criando DateTime sem parametros: {data}");

        data = new DateTime(2023, 02, 04, 14, 07, 33);
        Console.WriteLine($"Passando parametros. Ex: DateTime(2023, 02, 04, 14, 07, 33): {data}");
        Console.WriteLine("");

        data = DateTime.Now;
        Console.WriteLine($"DateTime.Now() retorna a data e hora atual: {data}");
        Console.WriteLine(" ");

        Console.WriteLine("--------------------------------");
        Console.WriteLine("Recuperando cada parametro de forma individual:");
        Console.WriteLine("--------------------------------");

        Console.WriteLine($"Ano: {data.Year}");
        Console.WriteLine($"Mês: {data.Month}");
        Console.WriteLine($"Dia: {data.Day}");
        Console.WriteLine($"Horas: {data.Hour}");
        Console.WriteLine($"Minutos: {data.Minute}");
        Console.WriteLine($"Segundos: {data.Second}");
        Console.WriteLine(" ");

        //Tratamento para retornar referências em português.
        var cultura = new CultureInfo("pt-BR");
        var nomeDoDiaDaSemana = cultura.DateTimeFormat.GetDayName(data.DayOfWeek);
        nomeDoDiaDaSemana = Util.PrimeiraLetraMaiuscula(nomeDoDiaDaSemana);

        var nomeDoMes = cultura.DateTimeFormat.GetMonthName(data.Month);
        nomeDoMes = Util.PrimeiraLetraMaiuscula(nomeDoMes);

        Console.WriteLine("--------------------------------");
        Console.WriteLine("Trabalhando os valores informados na data");
        Console.WriteLine("--------------------------------");

        Console.WriteLine($"Nome do mês: {nomeDoMes}");
        Console.WriteLine($"Nome do dia da semana: {nomeDoDiaDaSemana}");
        Console.WriteLine($"Enumerador do dia da semana de 0 a 6: {(int)data.DayOfWeek} - {nomeDoDiaDaSemana}");
        Console.WriteLine($"Dia do ano: {data.DayOfYear}");
        Console.WriteLine("");

        Console.WriteLine("--------------------------------");
        Console.WriteLine("Padrões de formatação");
        Console.WriteLine("--------------------------------");

        var formataData = string.Format("{0:yyyy-MM}", data);
        Console.WriteLine($"Exibe ano-mes: {formataData}");

        formataData = string.Format("{0:yyyy.MM.dd}", data);
        Console.WriteLine($"Exibe ano.mes.dia: {formataData}");

        formataData = string.Format("{0:dd-MM-yy hh:mm:ss ff z}", data);
        Console.WriteLine($@"Exibe dia-mes-ano, horas-minutos-segundos,
            (ff) fração de segundo e (z)ona de tempo: {formataData}"
        .Replace(Environment.NewLine, "")
        .Replace("            ", " "));
        Console.WriteLine("");

        formataData = string.Format("{0:d}", data);
        Console.WriteLine($"Formatação curta '0:d' | dia/mes/ano: {formataData}");

        formataData = string.Format("{0:D}", data);
        Console.WriteLine($"Formatação longa '0:D' | dia, mês e ano por extenso: {formataData}");
        Console.WriteLine("");

        formataData = string.Format("{0:t}", data);
        Console.WriteLine($"Formatação curta '0:t' | horas e minutos: {formataData}");

        formataData = string.Format("{0:T}", data);
        Console.WriteLine($"Formatação longa '0:T' | horas, minutos e segundos: {formataData}");
        Console.WriteLine("");

        formataData = string.Format("{0:f}", data);
        Console.WriteLine($"Formatação longa '0:f' | data e hora: {formataData}");

        formataData = string.Format("{0:F}", data);
        Console.WriteLine($"Formatação longa '0:F' | data, horas e minutos: {formataData}");
        Console.WriteLine("");

        formataData = string.Format("{0:g}", data);
        Console.WriteLine($"Formatação curta '0:g' | data, horas e minutos: {formataData}");

        formataData = string.Format("{0:G}", data);
        Console.WriteLine($"Formatação curta '0:G' | data, horas, minutos e segundos: {formataData}");
        Console.WriteLine("");

        formataData = string.Format("{0:r}", data);
        Console.WriteLine($"Formatação abreviada '0:r' ou '0:R' | data abreviada norma RFC 1123 Time Format : {formataData}");

        formataData = string.Format("{0:s}", data);
        Console.WriteLine($"Formatação abreviada '0:s' comum em NoSQL | data, horas, minutos e segundos: {formataData}");

        formataData = string.Format("{0:u}", data);
        Console.WriteLine($"Formatação abreviada '0:u' universal, mais usado em JSON | data, horas, minutos e segundos: {formataData}");
        Console.WriteLine("");

        Console.WriteLine("--------------------------------");
        Console.WriteLine("Adicionando valores as datas");
        Console.WriteLine("Utilize sempre os métodos Add do DateTime, pois já estão previstas regras de calendário.");
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Data atual: {data}");
        Console.WriteLine($"Adiciona 1 dia ao dia atual | data.AddDays(1): {data.AddDays(1)}");
        Console.WriteLine($"Remove 68 dias com base no dia atual | data.AddDays(-68): {data.AddDays(-68)}");
        Console.WriteLine($"Remove 2 meses com base no dia atual | data.AddMonths(2): {data.AddMonths(2)}");
        Console.WriteLine($"Adiciona 28 horas com base na hora atual | data.AddHours(28): {data.AddHours(28)}");
        Console.WriteLine("");

        Console.WriteLine("--------------------------------");
        Console.WriteLine("Comparando datas");
        Console.WriteLine("--------------------------------");
        var dataInformada = new DateTime(2021, 02, 01);
        var dataAtual = DateTime.Now.Date;

        Console.WriteLine($"Data Informada: {dataInformada}");
        Console.WriteLine($"Data atual: {dataAtual}");
        Util.VerificaQualDataEMaior(dataInformada, dataAtual);
        Console.WriteLine("");

        Console.WriteLine("--------------------------------");
        Console.WriteLine("Datas globalizadas");
        Console.WriteLine("--------------------------------");
        var dataUtc = DateTime.UtcNow;
        var fusoHorarioTailandia = TimeZoneInfo.FindSystemTimeZoneById("Asia/Bangkok");
        var dataHoraTailandia = TimeZoneInfo.ConvertTimeFromUtc(dataUtc, fusoHorarioTailandia);

        var fusoHorarioBrasil = TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo");
        var dataHoraBrasil = TimeZoneInfo.ConvertTimeFromUtc(dataUtc, fusoHorarioBrasil);

        Console.WriteLine($"Data UTC | Universal Time Coordinated | Padrão de tempo mundial: {dataUtc}");
        Console.WriteLine($"Fuso horário Brasil: {fusoHorarioBrasil}");
        Console.WriteLine($"Data e hora Brasil: {dataHoraBrasil}");
        Console.WriteLine($"Fuso horário Tailandia: {fusoHorarioTailandia}");
        Console.WriteLine($"Data e hora Tailandia: {dataHoraTailandia}");
        Console.WriteLine("");

        Console.WriteLine("--------------------------------");
        Console.WriteLine("Timespan - Fração de tempo");
        Console.WriteLine("--------------------------------");

        var fracao = new TimeSpan();
        var nanoSegundos = new TimeSpan(1);
        var horaMinutoSegundo = new TimeSpan(2, 13, 22);
        var diaHoraMinutoSegundo = new TimeSpan(15, 2, 13, 22);
        Console.WriteLine($"Fração de tempo: {fracao}");
        Console.WriteLine($"Nano segundos: {nanoSegundos}");
        Console.WriteLine($"Horas, minutos e segundos: {horaMinutoSegundo}");
        Console.WriteLine($"Dias, Horas, minutos e segundos: {diaHoraMinutoSegundo}");
        Console.WriteLine("");

        Console.WriteLine("--------------------------------");
        Console.WriteLine("Mais utilidades");
        Console.WriteLine("--------------------------------");

        var dataSelecionada = DateTime.Today;

        Console.WriteLine($"Quantos dias tem em março: {DateTime.DaysInMonth(2023, 3)}");
        Console.WriteLine($@"A data informada {dataSelecionada.ToShortDateString()}
            cai no fim de semana? {Util.EFimDeSemana(dataSelecionada.DayOfWeek)}"
        .Replace(Environment.NewLine, "")
        .Replace("            ", " "));

    }
}




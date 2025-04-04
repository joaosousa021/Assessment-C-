public class Formatura
{
    public static void Main()
    {

        Console.Write("Digite a data atual (DD/MM/AAAA): ");
        string entrada = Console.ReadLine();
        DateTime dataAtual = DateTime.Parse(entrada);

        DateTime dataFormatura = new DateTime(2026, 12, 15);



        //para testar a condição dos 6 meses faltantes e da data posterior a data da formatura comentar da linha 15 a linha 19 
        if (dataAtual > DateTime.Now)
        {
            Console.WriteLine("Erro: A data informada não pode ser no futuro!");
            return;
        }

        if (dataAtual > dataFormatura)
        {
            Console.WriteLine("Parabéns! Você já deveria estar formado!");
            return;
        }

        int diasRestantes = (dataFormatura - dataAtual).Days;
        int diasPorAno = 365;
        int diasPorMes = 30;

        int anos = diasRestantes / diasPorAno;
        int meses = (diasRestantes % diasPorAno) / diasPorMes;
        int dias = (diasRestantes % diasPorAno) % diasPorMes;
        int mesesParaAviso = 6;

        Console.WriteLine($"Faltam {anos} anos, {meses} meses e {dias} dias para sua formatura!");


        if (diasRestantes < mesesParaAviso * diasPorMes)
        {
            Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
        }


    }
}

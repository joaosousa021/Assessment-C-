public class Aniversario { 
    public static void Main()
    {
        Console.Write("Digite sua data de nascimento (DD/MM/AAAA): ");
        string entrada = Console.ReadLine(); 
        DateTime dataNascimento = DateTime.Parse(entrada);

        DateTime agora = DateTime.Now;
        DateTime proximoAniversario = new DateTime(agora.Year, dataNascimento.Month, dataNascimento.Day);

        if (proximoAniversario < agora)
        {
            proximoAniversario = proximoAniversario.AddYears(1);
        }


        int DiasRestantes = (proximoAniversario - agora).Days;

        Console.WriteLine("Faltam " + DiasRestantes + " dias para o seu aniversário");

        if (DiasRestantes <=7)
        {
            Console.WriteLine("Seu aniversário está chegando, se anime!");
        }

    }

}

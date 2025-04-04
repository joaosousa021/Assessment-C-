class Advinha {
    static void Main()
    {
        Random aleatorio = new Random();
        int numeroSecreto = aleatorio.Next(1, 51); 
        int tentativas = 5;

        Console.WriteLine("=== Jogo de Adivinhação ===");
        Console.WriteLine("Tente adivinhar o número de 1 a 50.");
        Console.WriteLine("Você tem 5 tentativas.");

        while (tentativas > 0)
        {
            Console.Write("Digite um número: ");
            int palpite = int.Parse(Console.ReadLine());

            if (palpite < 1 || palpite > 50)
            {
                Console.WriteLine("O número inserido não é permitido. Digite de 1 a 50.");
                continue;
            }

            if (palpite == numeroSecreto)
            {
                Console.WriteLine("Parabéns você acertou");
                break;
            }
            else
            {
                tentativas = tentativas - 1;

                if (palpite > numeroSecreto)
                {
                    Console.WriteLine("O número secreto é menor.");
                }
                else
                {
                    Console.WriteLine("O número secreto é maior.");
                }

                if (tentativas > 0)
                {
                    Console.WriteLine("Tentativas restantes: " + tentativas);
                }
                else
                {
                    Console.WriteLine("Acabaram suas tentativas.");
                    Console.WriteLine("O número era: " + numeroSecreto);
                }
            }
        }
    }
}

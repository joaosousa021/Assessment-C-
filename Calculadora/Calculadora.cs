using System;

public class Calculadora
{
    public static void Main()
    {
        double numero1, numero2;
        short escolha;
        double resultado = 0;

        while (true)
        {
            
            Console.Write("Digite o primeiro número: ");
            numero1 = double.Parse(Console.ReadLine());
            if (numero1 < 0)
            {
                Console.WriteLine("Números negativos não são permitidos. Tente novamente.");
                continue; // entra em looping até o usuário digitar um número positivo
            }


            Console.Write("Digite o segundo número: ");
            numero2 = double.Parse(Console.ReadLine());
            if (numero2 < 0)
            {
                Console.WriteLine("Números negativos não são permitidos. Tente novamente.");
                continue; //mesma coisa que no caso acima
            }

    
            Console.WriteLine("========== Calculadora ==========");
            Console.WriteLine("Digite 1 para Soma");
            Console.WriteLine("Digite 2 para Subtração");
            Console.WriteLine("Digite 3 para Multiplicação");
            Console.WriteLine("Digite 4 para Divisão");
            Console.WriteLine("Digite 5 para Sair");
            Console.Write("Opção: ");
            escolha = short.Parse(Console.ReadLine());

            if (escolha < 1 || escolha > 5)
            {
                Console.WriteLine("Essa escolha não existe. Digite uma opção de 1 a 5.");
                continue; // entra em looping até o usuário digitar uma opção entre 1 a 5 
            }
            else if (escolha == 5)
            {
                Console.WriteLine("Saindo da aplicação");
                break; //mata a aplicação caso escolha o numero 5
            }

    
            if (escolha == 1)
            {
                resultado = numero1 + numero2;
                Console.WriteLine("A operação escolhida foi a soma");
            }
            else if (escolha == 2)
            {
                resultado = numero1 - numero2;
                Console.WriteLine("A operação escolhida foi a subtração");
            }
            else if (escolha == 3)
            {
                resultado = numero1 * numero2;
                Console.WriteLine("A operação escolhida foi a multiplicação");
            }
            else if (escolha == 4)
            {
                if (numero1 == 0 || numero2 == 0)
                {
                    Console.WriteLine("Divisão por zero não é aceita escolha novos números que não sejam zero.");
                    continue; // volta para o inicio da aplicação para o usuario escolher novos números que não sejam zero.
                }
                resultado = numero1 / numero2;
                Console.WriteLine("A operação escolhida foi a divisão");
            }

            break; 
        }

        Console.WriteLine("Resultado final: " + resultado);
    }
}

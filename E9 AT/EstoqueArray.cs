class EstoqueArray
{
    static void Main()
    {
        string[] nomes = new string[5]; 
        int[] quantidades = new int[5]; 
        double[] precos = new double[5]; 
        int contador = 0; 

        while (true)
        {
            Console.WriteLine("======= Estoque De Produtos =======");
            Console.WriteLine("1 - Inserir Produto");
            Console.WriteLine("2 - Listar Produtos");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha: ");
            string opcao = Console.ReadLine();

            if (opcao == "1") 
            {
                if (contador >= 5)
                {
                    Console.WriteLine("O limite de produtos é 5.");
                    continue;
                }

                Console.Write("Nome do Produto: ");
                nomes[contador] = Console.ReadLine();

                Console.Write("Quantidade: ");
                quantidades[contador] = int.Parse(Console.ReadLine());

                Console.Write("Preço: ");
                precos[contador] = double.Parse(Console.ReadLine());

                contador++;
                Console.WriteLine("Produto cadastrado!");
            }
            else if (opcao == "2") 
            {
                if (contador == 0)
                {
                    Console.WriteLine("Nenhum produto no estoque");
                }
                else
                {
                    Console.WriteLine("=== Produtos No Estoque ===");
                    for (int i = 0; i < contador; i++)
                    {
                        Console.WriteLine($"Produto: {nomes[i]} | Quantidade: {quantidades[i]} | Preço: R$ {precos[i]}");
                    }
                }
            }
            else if (opcao == "3") 
            {
                Console.WriteLine("Saindo...");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida! Tente novamente.");
            }
        }
    }
}
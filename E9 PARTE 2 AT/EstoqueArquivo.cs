
class EstoqueArquivo
{
    static void Main()
    {
        string caminhoArquivo = "estoque.txt";

        while (true)
        {
            Console.WriteLine("=== Estoque de Produtos ===");
            Console.WriteLine("1 - Inserir Produto");
            Console.WriteLine("2 - Listar Produtos");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");
            short opcao = short.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Nome do produto: ");
                string nomeProduto = Console.ReadLine();

                Console.Write("Quantidade de produtos: ");
                int quantidadeProduto = int.Parse(Console.ReadLine());

                Console.Write("Preço do produto: ");
                double precoProduto = double.Parse(Console.ReadLine());

                string produtoFormatado = nomeProduto + "," + quantidadeProduto + "," + precoProduto;

               
                using (StreamWriter escritor = new StreamWriter(caminhoArquivo, true))
                {
                    escritor.WriteLine(produtoFormatado);
                }

                Console.WriteLine("Produto cadastrado com sucesso!");
            }
            else if (opcao == 2)
            {
                if (!File.Exists(caminhoArquivo))
                {
                    Console.WriteLine("Nenhum produto cadastrado.");
                }
                else
                {
                    using (StreamReader leitor = new StreamReader(caminhoArquivo))
                    {
                        Console.WriteLine("======= Produtos em Estoque =======");

                        if (leitor.EndOfStream)
                        {
                            Console.WriteLine("Nenhum produto cadastrado.");
                        }
                        else
                        {
                            while (!leitor.EndOfStream)
                            {
                                string linhaProduto = leitor.ReadLine();
                                string[] dadosProduto = linhaProduto.Split(',');

                                Console.WriteLine($"Produto: {dadosProduto[0]} | Quantidade: {dadosProduto[1]} | Preço: R$ {dadosProduto[2]}");
                            }
                        }
                    }
                }
            }
            else if (opcao == 3)    
            {
                Console.WriteLine("Saindo do sistema...");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida! Digite um número válido.");
            }
        }
    }
}


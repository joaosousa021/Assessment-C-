class Contatos {
    static void Main()
    {
        string caminhoArquivo = "contatos.txt";

        while (true)
        {
            Console.WriteLine("=============== Gerenciador de Contatos ===============");
            Console.WriteLine("1 - Adicionar novo contato");
            Console.WriteLine("2 - Listar contatos cadastrados");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");
            short opcao = short.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Nome: ");
                string nomeContato = Console.ReadLine();

                Console.Write("Telefone: ");
                string telefoneContato = Console.ReadLine();

                Console.Write("Email: ");
                string emailContato = Console.ReadLine();

                string contatoFormatado = nomeContato + "," + telefoneContato + "," + emailContato;

                using (StreamWriter escritor = new StreamWriter(caminhoArquivo, true))
                {
                    escritor.WriteLine(contatoFormatado);
                }

                Console.WriteLine("Contato cadastrado com sucesso");
            }
            else if (opcao == 2)
            {
                if (!File.Exists(caminhoArquivo))
                {
                    Console.WriteLine("Nenhum contato cadastrado.");
                }
                else
                {
                    using (StreamReader leitor = new StreamReader(caminhoArquivo))
                    {
                        Console.WriteLine("=============== Contatos Cadastrados ===============");

                        if (leitor.EndOfStream)
                        {
                            Console.WriteLine("Nenhum contato cadastrado.");
                        }
                        else
                        {
                            while (!leitor.EndOfStream)
                            {
                                string linhaContato = leitor.ReadLine();
                                string[] dadosContato = linhaContato.Split(',');

                                Console.WriteLine($"Nome: {dadosContato[0]} | Telefone: {dadosContato[1]} | Email: {dadosContato[2]}");
                            }
                        }
                    }
                }
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Programa encerrado");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida. Digite um número válido.");
            }
        }
    }
}


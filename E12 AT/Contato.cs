

class Contato
{
    public string Nome;
    public string Telefone;
    public string Email;

    public Contato(string nome, string telefone, string email)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
    }
}

class FormatoContato
{
    public virtual void ExibirContatos(List<Contato> contatos) { }
}

//esse formato não imprime os emojis no cmd por isso retirei os emojis para não ficar feio no cmd.
class FormatoMarkdown : FormatoContato
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        Console.WriteLine("=============== Formato Markdown ===============");
        Console.WriteLine("## Lista de Contatos");

        int i = 0;
        while (i < contatos.Count)
        {
            Console.WriteLine($"- **Nome:** {contatos[i].Nome}");
            Console.WriteLine($"- Telefone: {contatos[i].Telefone}");
            Console.WriteLine($"- Email: {contatos[i].Email}");
            i++;
        }
    }
}

class FormatoTabela : FormatoContato
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        Console.WriteLine("=============== Formato Tabela ===============");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("| Nome          | Telefone      | Email          |");
        Console.WriteLine("----------------------------------------");

        int i = 0;
        while (i < contatos.Count)
        {
            Console.WriteLine($"| {contatos[i].Nome} | {contatos[i].Telefone} | {contatos[i].Email} |");
            i++;
        }

        Console.WriteLine("----------------------------------------");
    }
}

class FormatoRaw : FormatoContato
{
    public override void ExibirContatos(List<Contato> contatos)
    {
        Console.WriteLine("=============== Formato Texto Puro ===============");

        int i = 0;
        while (i < contatos.Count)
        {
            Console.WriteLine($"Nome: {contatos[i].Nome} | Telefone: {contatos[i].Telefone} | Email: {contatos[i].Email}");
            i++;
        }
    }
}

class GerenciadorContatos
{
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
                string nome = Console.ReadLine();

                Console.Write("Telefone: ");
                string telefone = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                using (StreamWriter escritor = new StreamWriter(caminhoArquivo, true))
                {
                    escritor.WriteLine($"{nome},{telefone},{email}");
                }

                Console.WriteLine("Contato cadastrado");
            }
            else if (opcao == 2)
            {
                if (!File.Exists(caminhoArquivo))
                {
                    Console.WriteLine("Nenhum contato cadastrado");
                    continue;
                }

                List<Contato> contatos = new List<Contato>();

                using (StreamReader leitor = new StreamReader(caminhoArquivo))
                {
                    while (!leitor.EndOfStream)
                    {
                        string[] dados = leitor.ReadLine().Split(',');
                        if (dados.Length == 3)
                        {
                            contatos.Add(new Contato(dados[0], dados[1], dados[2]));
                        }
                    }
                }

              
                new FormatoMarkdown().ExibirContatos(contatos);
                new FormatoTabela().ExibirContatos(contatos);
                new FormatoRaw().ExibirContatos(contatos);
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Programa encerrado");
                break;
            }
            else
            {
                Console.WriteLine("Digite uma opção correspondente.");
            }
        }
    }
}

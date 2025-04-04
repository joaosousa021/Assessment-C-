public class ContaBancaria
{
    public string nomeDoTitular;
    private decimal saldo;

    public ContaBancaria(string nomeDoTitular, decimal saldo)
    {
        this.nomeDoTitular = nomeDoTitular;
        this.saldo = saldo;
    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            System.Console.WriteLine("Não é possível efetuar deposítos negativos");
            return;
        }

        saldo += valor;
        System.Console.WriteLine($"Depósito de R$ {valor} realizado com sucesso!");
       
    }

    public void Sacar(decimal valor)
    {
        if (saldo < valor)
        {
            System.Console.WriteLine("Saldo insuficiente para realizar o saque!");
            return;
        }

        saldo -= valor;
        System.Console.WriteLine($"Saque de R$ {valor} realizado com sucesso!");
        
    }

    public void ExibirSaldo()
    {
        System.Console.WriteLine($"Saldo atual: R$ {saldo}");
    }

    public void ExibirTitular()
    {
        System.Console.WriteLine($"Olá {nomeDoTitular}. Seja bem vindo");
    }

    public static void Main()
    {
        ContaBancaria conta1 = new ContaBancaria("João Pedro Sousa", 1000);

        conta1.ExibirTitular();
        conta1.ExibirSaldo();
        conta1.Depositar(-300);
        

       
    }
}

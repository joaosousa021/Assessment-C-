public class Empresa
{
    public class Funcionario
    {
        protected string nome;
        protected string cargo;
        protected double salarioBase;


        public Funcionario(string nome, string cargo, double salarioBase)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salarioBase = salarioBase;
        }

        public void ExibirSalario()
        {
            System.Console.WriteLine($"Nome:{nome}, Cargo:{cargo}, Salário: R$ {salarioBase}");
        }

       protected double GetSalarioBase()
        {
            return salarioBase;
        }

    }

    public class Gerente : Funcionario {
        public Gerente(string nome, double salarioBase) : base(nome,  "Gerente", salarioBase)
        {
            base.salarioBase += base.salarioBase * 0.20; 
        }


    }

    public static void Main()
    {
        Funcionario funcionario = new Funcionario("João Pedro", "Engenheiro de Software", 7000);
        Gerente gerente = new Gerente("Sousa Santana", 7000);

        funcionario.ExibirSalario();
        gerente.ExibirSalario();
    }

}



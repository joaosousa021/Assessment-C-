

public class Alunos
{
    public string nome, curso;
    public int matricula;
    public double mediaDasNotas;

   

    public void ExibirDados()
    {
        System.Console.WriteLine("Nome: " + nome);
        System.Console.WriteLine("Curso: " + curso);
        System.Console.WriteLine("Matrícula: "+matricula);
        System.Console.WriteLine("Média das Notas: " + mediaDasNotas);
    }

    public void VerificarAprovacao()
    {
        if (mediaDasNotas >= 7)
        {
            System.Console.WriteLine("Status: Aprovado");
        }
        else
        {
            System.Console.WriteLine("Status: Reprovado");
        }
    }
    public static void Main()
    {
        Alunos aluno1 = new Alunos();
        aluno1.nome = "João Pedro Sousa";
        aluno1.curso = "Engenharia de Software";
        aluno1.matricula = 26022024;
        aluno1.mediaDasNotas = 6.6;

        aluno1.ExibirDados();
        aluno1.VerificarAprovacao();



    }
}
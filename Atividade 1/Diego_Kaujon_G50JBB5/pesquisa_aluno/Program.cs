using System;

class Program
{
    static void Main(string[] args)
    {
        // Criar um objeto Aluno para representar o aluno cadastrado
        Aluno alunoCadastrado = new Aluno("Carlinhos", "12345678910");

        // Solicitar entrada do usuário para o RA
        Console.Write("Digite o RA do aluno: ");
        string raDigitado = Console.ReadLine();

        // Verificar se o RA corresponde ao aluno cadastrado
        if (alunoCadastrado.VerificarRA(raDigitado))
        {
            Console.Clear();
            Console.WriteLine("Aluno encontrado: " + alunoCadastrado.Nome);
        }
        else
        {
            Console.WriteLine("Esse aluno não existe!");
        }

        // Pausar para ler a mensagem antes de fechar o programa
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}



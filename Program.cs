Atividade10();

static void Atividade10()
{
    string[] estudantes = new string[8];

    for (int i = 0; i < estudantes.Length; i++)
    {
        Console.Write("Informe o nome do estudante: ");
        estudantes[i] = Console.ReadLine()!;
    }

    Console.Write("Informe o nome para busca: ");
    string busca = Console.ReadLine()!;

    int posicaoEncontrada = -1;

    for (int i = 0; i < estudantes.Length; i++)
    {
        if (estudantes[i] == busca)
        {
            posicaoEncontrada = i + 1; // posição começa em 1
            break;
        }
    }

    if (posicaoEncontrada != -1)
    {
        Console.WriteLine($"\nEstudante encontrado na posição {posicaoEncontrada}.");
    }
    else
    {
        Console.WriteLine("\nEstudante não encontrado.");
    }
}
Atividade9();

static void Atividade9()
{
    string[] tarefas = new string[5];
    int[] prioridades = new int[5];

    int baixa = 0;
    int media = 0;
    int alta = 0;

    for (int i = 0; i < tarefas.Length; i++)
    {
        Console.Write("Informe o nome da tarefa: ");
        tarefas[i] = Console.ReadLine()!;

        Console.Write("Informe a prioridade da tarefa: ");
        prioridades[i] = Convert.ToInt32(Console.ReadLine());

        if (prioridades[i] == 1)
        {
            baixa++;
        }
        else if (prioridades[i] == 2)
        {
            media++;
        }
        else if (prioridades[i] == 3)
        {
            alta++;
        }
    }

    Console.WriteLine($"\nTarefas de baixa prioridade: {baixa}");
    Console.WriteLine($"Tarefas de média prioridade: {media}");
    Console.WriteLine($"Tarefas de alta prioridade: {alta}");

    Console.WriteLine("\nTarefas de alta prioridade:");

    for (int i = 0; i < tarefas.Length; i++)
    {
        if (prioridades[i] == 3)
        {
            Console.WriteLine($"- {tarefas[i]}");
        }
    }
}
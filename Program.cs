Atividade2();

static void Atividade2()
{
    int[] idades = new int[8];
    int menores = 0;
    int maiores = 0;

    for (int i = 0; i < idades.Length; i++)
    {
        Console.Write("Informe a idade do estudante: ");
        idades[i] = Convert.ToInt32(Console.ReadLine());

        if (idades[i] < 18)
        {
            menores++;
        }
        else
        {
            maiores++;
        }
    }

    Console.WriteLine($"\nQuantidade de menores de idade: {menores}");
    Console.WriteLine($"Quantidade de maiores de idade: {maiores}");
}

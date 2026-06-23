Atividade1();

static void Atividade1()
{
    double[] notas = new double[5];
    double soma = 0;
    double media;

    for (int i = 0; i < notas.Length; i++)
    {
        Console.Write("Informe a nota: ");
        notas[i] = Convert.ToDouble(Console.ReadLine());

        soma += notas[i];
    }

    media = soma / notas.Length;

    Console.WriteLine($"\nSoma das notas: {soma}");
    Console.WriteLine($"Média final: {media}");
}
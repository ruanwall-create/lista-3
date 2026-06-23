Atividade4();

static void Atividade4()
{
    double[] horasEstudadas = new double[7];
    double totalHoras = 0;
    int metaAtingida = 0;
    int metaNaoAtingida = 0;

    for (int i = 0; i < horasEstudadas.Length; i++)
    {
        Console.Write("Informe as horas estudadas no dia: ");
        horasEstudadas[i] = Convert.ToDouble(Console.ReadLine());

        totalHoras += horasEstudadas[i];

        if (horasEstudadas[i] >= 2)
        {
            metaAtingida++;
        }
        else
        {
            metaNaoAtingida++;
        }
    }

    Console.WriteLine($"\nTotal de horas estudadas: {totalHoras}");
    Console.WriteLine($"Dias com meta atingida: {metaAtingida}");
    Console.WriteLine($"Dias com meta não atingida: {metaNaoAtingida}");
}
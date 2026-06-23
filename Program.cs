Atividade3();

static void Atividade3()
{
    double[] gastos = new double[7];
    double total = 0;

    for (int i = 0; i < gastos.Length; i++)
    {
        Console.Write("Informe o gasto do dia: ");
        gastos[i] = Convert.ToDouble(Console.ReadLine());

        total += gastos[i];
    }

    double media = total / gastos.Length;

    double maior = gastos[0];
    double menor = gastos[0];

    for (int i = 1; i < gastos.Length; i++)
    {
        if (gastos[i] > maior)
        {
            maior = gastos[i];
        }

        if (gastos[i] < menor)
        {
            menor = gastos[i];
        }
    }

    Console.WriteLine($"\nTotal gasto na semana: R$ {total}");
    Console.WriteLine($"Média diária de gastos: R$ {media}");
    Console.WriteLine($"Maior gasto: R$ {maior}");
    Console.WriteLine($"Menor gasto: R$ {menor}");
}
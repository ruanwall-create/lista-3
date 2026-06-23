Atividade5();

static void Atividade5()
{
    double[] temperaturas = new double[6];
    double soma = 0;

    for (int i = 0; i < temperaturas.Length; i++)
    {
        Console.Write("Informe a temperatura registrada: ");
        temperaturas[i] = Convert.ToDouble(Console.ReadLine());

        soma += temperaturas[i];
    }

    double media = soma / temperaturas.Length;

    int diasAcimaMedia = 0;
    double maior = temperaturas[0];
    double menor = temperaturas[0];

    for (int i = 0; i < temperaturas.Length; i++)
    {
        if (temperaturas[i] > media)
        {
            diasAcimaMedia++;
        }

        if (temperaturas[i] > maior)
        {
            maior = temperaturas[i];
        }

        if (temperaturas[i] < menor)
        {
            menor = temperaturas[i];
        }
    }

    Console.WriteLine($"\nMédia das temperaturas: {media}");
    Console.WriteLine($"Dias acima da média: {diasAcimaMedia}");
    Console.WriteLine($"Maior temperatura: {maior}");
    Console.WriteLine($"Menor temperatura: {menor}");
}
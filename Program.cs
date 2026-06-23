Atividade7();

static void Atividade7()
{
    string[] produtos = new string[5];
    double[] precos = new double[5];

    double total = 0;

    string produtoMaisCaro;
    string produtoMaisBarato;

    for (int i = 0; i < produtos.Length; i++)
    {
        Console.Write("Informe o nome do produto: ");
        produtos[i] = Console.ReadLine();

        Console.Write("Informe o preço do produto: ");
        precos[i] = Convert.ToDouble(Console.ReadLine());

        total += precos[i];
    }

    double maiorPreco = precos[0];
    double menorPreco = precos[0];

    produtoMaisCaro = produtos[0];
    produtoMaisBarato = produtos[0];

    for (int i = 1; i < precos.Length; i++)
    {
        if (precos[i] > maiorPreco)
        {
            maiorPreco = precos[i];
            produtoMaisCaro = produtos[i];
        }

        if (precos[i] < menorPreco)
        {
            menorPreco = precos[i];
            produtoMaisBarato = produtos[i];
        }
    }

    Console.WriteLine($"\nProduto mais caro: {produtoMaisCaro}");
    Console.WriteLine($"Preço do produto mais caro: R$ {maiorPreco}");

    Console.WriteLine($"Produto mais barato: {produtoMaisBarato}");
    Console.WriteLine($"Preço do produto mais barato: R$ {menorPreco}");

    Console.WriteLine($"Total dos preços: R$ {total}");
}
Atividade6();

static void Atividade6()
{
    int[] numeros = new int[10];

    int positivos = 0;
    int negativos = 0;
    int zeros = 0;
    int pares = 0;
    int impares = 0;

    for (int i = 0; i < numeros.Length; i++)
    {
        Console.Write("Informe um número inteiro: ");
        numeros[i] = Convert.ToInt32(Console.ReadLine());

        if (numeros[i] == 0)
        {
            zeros++;
            pares++; // zero é considerado par
        }
        else
        {
            if (numeros[i] > 0)
            {
                positivos++;
            }
            else
            {
                negativos++;
            }

            if (numeros[i] % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
        }
    }

    Console.WriteLine($"\nQuantidade de positivos: {positivos}");
    Console.WriteLine($"Quantidade de negativos: {negativos}");
    Console.WriteLine($"Quantidade de zeros: {zeros}");
    Console.WriteLine($"\nQuantidade de pares: {pares}");
    Console.WriteLine($"Quantidade de ímpares: {impares}");
}
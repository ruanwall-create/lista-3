Atividade8();

static void Atividade8()
{
    int[] votos = new int[12];

    int pizza = 0;
    int hamburguer = 0;
    int pastel = 0;

    for (int i = 0; i < votos.Length; i++)
    {
        Console.Write("Informe o voto do estudante: ");
        votos[i] = Convert.ToInt32(Console.ReadLine());

        if (votos[i] == 1)
        {
            pizza++;
        }
        else if (votos[i] == 2)
        {
            hamburguer++;
        }
        else if (votos[i] == 3)
        {
            pastel++;
        }
    }

    Console.WriteLine($"\nVotos para Pizza: {pizza}");
    Console.WriteLine($"Votos para Hambúrguer: {hamburguer}");
    Console.WriteLine($"Votos para Pastel: {pastel}");
}
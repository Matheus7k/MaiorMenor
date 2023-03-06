internal class Program
{
    static float Maior(float[] numeros)
    {
        float maior = numeros[0];

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
        }
        return maior;
    }

    static float Menor(float[] numeros)
    {
        float menor = numeros[0];

        for(int i = 0; i < numeros.Length;i++)
        {
            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }
        return menor;
    }

    private static void Main(string[] args)
    {
        float[] numeros = new float[15];

        for (int i = 0; i < 15; i++)
        {
            Console.Write($"Insira o {i+1}° numero: ");
            numeros[i] = float.Parse(Console.ReadLine());
        }

        Console.WriteLine($"O maior numero inserido foi: {Maior(numeros)}, e o menor foi: {Menor(numeros)}");
    }
}
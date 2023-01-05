namespace Parte4;

public class Ejercicios4
{
    //Suma de elementos de un vector y la media aritmetica
    public void SumaVector()
    {
        int[,] array1 = new int[3, 3] { { 10, 5, 100 }, { 50, 75, 25 }, { 10, 5, 100 } };

        int sumaFila = 0;

        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{array1[i, j]} ");
                sumaFila += array1[i, j];
            }
            Console.WriteLine($"La suma es: {sumaFila}");
            Console.WriteLine($"");
        }

    }

    //Contar el numero de elementos positivos de un array
    public void Conteo()
    {

        int cuenta = 0;
        int[] numeros = new int[10] { 2, -2, -4, -5, 6, 7, 6, -9, 7, 6 };
        for (int i = 0; i < numeros.Length; i++)
        {
            // int item = numeros[i];
            if (numeros[i] > 0)
            {
                cuenta++;
            }
        }

        Console.WriteLine($"{cuenta}");
    }
}
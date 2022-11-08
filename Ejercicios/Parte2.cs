namespace Parte2
{
    public class Ejercicios2
    {
        //Daddos 10 numeros enteros visualizar la suma de los numeros pares
        //cuanttos numeros pares existen y la media de los numeros impares
        public void ParesImpares()
        {
            int[] sumar = new int[] { 2, 3, 4, 5, 5, 7, 9, 32, 45, 43 };
            int sumaPares = 0;
            int mediaImpares = 0;
            int contadorPares = 0;
            for (var i = 0; i < sumar.Length; i++)
            {
                if (sumar[i] % 2 == 0)
                {
                    sumaPares += sumar[i];
                    contadorPares++;
                }
                else
                {
                    mediaImpares = sumar[i] / sumar.Length;
                }
            }
            Console.WriteLine($"Suma: {sumaPares} Media: {mediaImpares} Cantidad: {contadorPares}");
        }

        //Sumar 10 numero ingresados por el teclado
        public void SumaDIez()
        {
            int[] sumar = new int[10];
            var resultado = 0;

            for (var i = 0; i < sumar.Length; i++)
            {
                Console.WriteLine($"Digite un numero para sumar: ");
                sumar[i] = Convert.ToInt32(Console.ReadLine());
                // sumar = Console.ReadLine();
                resultado += sumar[i];
            }

            Console.WriteLine($"{resultado}");

        }

        //leer 500 numeros y decir cuantos son positivos
        public void NumerosPositivos()
        {
            var contador = 0;
            var randomNumber = new Random();

            for (int i = 0; i <= 500; i++)
            {
                var value = randomNumber.Next(-500, 500);
                if (value < 0)
                {
                    contador++;
                }

            }
            Console.WriteLine($"{contador}");

        }


        // Clacular la suma y el producto de los numeros pares compendidos 
        //EntryPointNotFoundException 20 y 400, ambos inclusive

        public void Mostrar()
        {
            var resultado = 0;
            for (var i = 20; i <= 400; i++)
            {
                if (i % 2 == 0)
                {
                    resultado += i;
                }

            }
            Console.WriteLine($"La suma es: {resultado}");
        }

        //Sumar los pares hasta el 200
        public void Imprimir()
        {
            var resultado = 0;
            var contador = 0;
            for (var i = 0; i < 200; i++)
            {
                if (i % 2 == 0)
                {
                    resultado += contador;

                }
                contador++;
            }
            Console.WriteLine($"La suma de los pares es: {resultado}");
        }
    }

}
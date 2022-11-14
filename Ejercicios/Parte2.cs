namespace Parte2
{
    public class Ejercicios2
    {


        //Desarrollar un algoritmo que determine en un conjunto de 100 numeros naturales
        //Cuantos numero son menores de 15
        //Cuantos mayores de 50
        // Cuantso entre 25 y 45
        public void NumerosNaturales()
        {
            var menores = 0;
            var mayores = 0;
            var entre = 0;
            var randomNumber = new Random();

            for (var i = -100; i < 100; i++)
            {
                var value = randomNumber.Next(-100, 99);
                if (value < 15)
                {
                    menores++;
                }
                if (value > 50)
                {
                    mayores++;
                }
                if (value < 45 && value > 25)
                {
                    entre++;
                }
            }

            Console.WriteLine($"{menores} {mayores} {entre}");

        }

        //Escribir la suma de los diez primeros numeros pares
        public void Suma10()
        {
            int suma = 0;
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }

            }
            Console.WriteLine($"{suma}");

        }

        // Calcular la nota media de los alumnos de una clase considerando n numero de alumnos y c numero de notas de cada alumno
        public void NotasEstudiantes()
        {
            Console.WriteLine("Digite el numero de estudiantes: ");
            int nEstudiantes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el numero de notas: ");
            int nNotas = Convert.ToInt32(Console.ReadLine());
            var suma = 0;
            var media = 0;
            int[,] notas = new int[nEstudiantes, nNotas];

            for (var i = 0; i < nEstudiantes; i++)
            {
                Console.WriteLine($"Digite las notas del {i + 1} estudiantes:");
                for (var j = 0; j < nNotas; j++)
                {
                    Console.Write($"Digite la nota del {j + 1} del estudiante {i + 1}:");
                    notas[i, j] = Convert.ToInt32(Console.ReadLine());
                    suma += notas[i, j];
                }

            }
            media = suma / nNotas;
            Console.WriteLine($"{media}");


        }

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
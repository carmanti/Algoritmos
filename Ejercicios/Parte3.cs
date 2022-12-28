namespace Parte3;
public class Ejercicios3
{

    //Escribir una función salario que calcule los salarios de un trabajador para un numero de horas
    //trabajdo y un salario de hora. las horas que superen las 40 horas semanales se pagaran como extras
    //con un salario 1,5 el salario ordinario
    public double Salario()
    {

        const double valorHora = 8;
        double salario = 0;
        Console.WriteLine($"Digite el numero de horas trabajadas: ");
        double horas = Convert.ToDouble(Console.ReadLine());

        if (horas < 40)
        {
            Console.WriteLine(salario = valorHora * horas);
        }
        if (horas > 40)
        {
            Console.WriteLine(salario = (valorHora * 40) + (horas - 40) * 1.5);
            Console.WriteLine($"La cantidad de horas extras son: {horas - 40}");

        }
        return salario;

    }

    // Diseñar una funcion que acepte el dia mes y año y presente en formato dd/mm/aa
    public void FormatoFecha()
    {
        Console.Write($"Digite el año: ");
        // string año = Convert.ToInt32(Console.ReadLine());
        string? año = Console.ReadLine();
        Console.Write($"Digite el mes: ");
        string? mes = Console.ReadLine();
        Console.Write($"Digite el dia: ");
        string? dia = Console.ReadLine();
        // string fecha = Console.WriteLine(Convert.ToString($"{año}/{mes}/{dia}"));
        string fecha = $"{año}/{mes}/{dia}";
        System.Console.WriteLine(fecha);

    }

    //Mayor de dos numeros
    public void Mayor()
    {
        Console.WriteLine("Digite un numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite un numero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"El primer numero es: {num1} el segundo: {num2}");

        if (num1 > num2)
        {
            Console.WriteLine($"{num1} es mayor");
        }
        else if (num2 > num1)
        {
            Console.WriteLine($"{num2} es mayor");

        }
        else
        {
            Console.WriteLine($"Los numero son iguales");

        }
    }
    //Diseñar una funcion para cambiar de valor dos cariable a y b
    public void CambioValor()
    {
        int a = 5, b = 4, c = 0;
        Console.WriteLine($"{a}{b}{c}");

        c = a;
        a = b;
        b = c;
        Console.WriteLine($"{a}{b}{c}");

    }

    //Diseñar una funcion que calcule a media de 3 numeros leidos por teclado
    //y poner un ejemplo de su aplicacion
    public float MediaNumeros()
    {
        int resultado = 0;
        float media = 0;
        for (var i = 0; i < 3; i++)
        {
            Console.Write($"Digite un numero: ");
            var x = Convert.ToInt32(Console.ReadLine());
            resultado += x;
        }
        return media = resultado / 3;
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
}
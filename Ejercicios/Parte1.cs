using System;
namespace Parte1{
    public class Ejercicios{

        //Convertir de grados celcius a fahrenheit
        public void Convertir(){
            Console.WriteLine($"Digite temperatura");
            int grados = Convert.ToInt32(Console.ReadLine());
            double fahrenheit = (9/5)* grados +32;
            Console.WriteLine($"Los grados convertidos son: {fahrenheit}");          
            
        }

        //Pedir los nombres de los autos y su modelo y mostrar en pantalla
        public void NombreAuto(){
            System.Console.WriteLine("Digite marca del auto:");
            string? auto = Console.ReadLine();
            System.Console.WriteLine("Digite el modelo del auto:");
            string? modelo = Console.ReadLine();

            Console.WriteLine($"{auto} {modelo}");
            

        }
    //Determinar el área y el volumende un cilindro cuyas dimensiones radio y altura se leen desde teclado
        public void Calcular(){
            int radio, altura;
            System.Console.WriteLine("Digite el rado: ");
            radio = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Digite el altura: ");
            altura = Convert.ToInt32(Console.ReadLine());

            double resultadoArea = 2*Math.PI*radio + 2*Math.PI*Math.Pow(radio,2);
            double resultadoVolumen = Math.PI * Math.Pow(radio,2)* altura;

            Console.WriteLine($"El área es: {resultadoArea} El voumen es {resultadoVolumen}");
             
        }
        //Escribir un algoritmo que calcule y escriba el cuadrado de 243
        public double Elevado(double numero){
            double resultado = Math.Pow(243, 2);
            return resultado;
        }
        //Pedir numero y sacar el cuadrado
        public void Ingresado(){
            Console.WriteLine("Digite un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            double resultado = Math.Pow(numero, 2);
            Console.WriteLine(resultado);
        }   
    }

    
}
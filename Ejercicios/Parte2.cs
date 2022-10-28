namespace Parte2
{
    public class Ejercicios2
    {

        

        //Sumar los pares hasta el 200
        public void Imprimir(){
            var resultado=0;
            var contador = 0;
            for (var i = 0; i < 200; i++)
            {
                if (i%2==0)
                {
                    resultado += contador;
                    
                }
                    contador++;
            }
                    Console.WriteLine($"La suma de los pares es: {resultado}");
        }        
    }
    
}
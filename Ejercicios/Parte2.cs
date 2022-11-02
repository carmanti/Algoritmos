namespace Parte2
{
    public class Ejercicios2
    {

        //leer 500 numeros y decir cuantos son positivos
        public void NumerosPositivos(){
            var contador=0;
            var randomNumber = new Random();

                for (int i = -500; i <= 500; i++)
                {
                    var value = randomNumber.Next(-500, 500);
                    if(value <0){
                        contador++;
                    }

                }
                Console.WriteLine($"{contador}");
            
        }


        // Clacular la suma y el producto de los numeros pares compendidos 
        //EntryPointNotFoundException 20 y 400, ambos inclusive

        public void Mostrar(){
            var resultado=0;
            for(var i=20; i<=400; i++){
                if(i%2 == 0){
                    resultado += i;
                }
                
            }
                Console.WriteLine($"La suma es: {resultado}");
        }

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
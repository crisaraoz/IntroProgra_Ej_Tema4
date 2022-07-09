using System;

namespace Ejercicios_tema_4
{
    /*Ejercicios_Tema4
     */
    class OpenBootcamp
    {
        static void Main(string[] args)
        {

            /*IF --
            Usando un if, crear una condición que compare si la variable numeroIf es positivo, negativo, o 0.
            */
            Random rnd = new Random();
            float numeroIf = rnd.Next(-10,11);
            Console.WriteLine("Numero IF: "+numeroIf);
            if (numeroIf > 0)
            {
                Console.WriteLine("El numero es Positivo");
            }else if (numeroIf == 0)
            {
                Console.WriteLine("El numero es Cero");
            }
            else
            {
                Console.WriteLine("El numero es Negativo");
            }
            


            /*WHILE 
            Crea un bucle While, este bucle tendrá que tener como condición que la variable numeroWhile sea inferior a 3, 
            el bloque de código que tendrá el bucle deberá:

            - Incrementar el valor de la variable en uno cada vez que se ejecute.
            - Mostrarlo por pantalla cada vez que se ejecute.
            */

            Random rnd2 = new Random();
            float numeroWhile = rnd2.Next(-5, 5);
            Console.WriteLine("Numero While: "+numeroWhile);

            while(numeroWhile < 3)
            {
                numeroWhile = numeroWhile + 1;
                Console.WriteLine("Numero While Actualizado: " + numeroWhile);
            }
            

            /*DO WHILE
             Para el bucle Do While, deberás crear la misma estructura que en el While, pero solo se debe ejecutar una vez.
            */

            Random rnd2 = new Random();
            float numeroWhile = rnd2.Next(-1, 2);
            Console.WriteLine("Numero While: " + numeroWhile);

            do
            {
                numeroWhile = numeroWhile + 1;
                Console.WriteLine("Numero While Actualizado: " + numeroWhile);
            } while (numeroWhile < 3);
            

            /*FOR
             Para el bucle For, crea una variable numeroFor, esta variable tendrá como valor 0 
             y su condición será que la variable sea igual o menor que 3, se irá incrementando en 1 su valor cada vez que se ejecute y deberá mostrarse por pantalla.
             */

            int numeroFor = 0;
            for (int i = 0; numeroFor <= 3; i++)
            {
                numeroFor = numeroFor + 1;
                Console.WriteLine(numeroFor);
            }
            

            /* SWITCH
             Por último, para el Switch, deberás crear la variable estacion, y distintos case para las cuatro estaciones del año. 
             Dependiendo del valor de la variable estacion se deberá mandar un mensaje por consola informando de la estación en la que está. 
             También habrá que poner un default para cuando el valor de la variable no sea una estación.
             */

            //CONSTANTES:  1 - VERANO , 2 - OTOÑO , 3 - INVIERNO , 4 - PRIMAVERA
            int mes= 0;
            int estacion=0;
            Console.Write("Ingrese el Mes (Por favor solo numeros: ");
            mes = int.Parse(Console.ReadLine());
            switch (mes)
            {
                case 1:
                    estacion = 1;
                    break;
                case 2:
                    estacion = 1;
                    break;
                case 3:
                    estacion = 1;
                    break;
                case 4:
                    estacion = 2;
                    break;
                case 5:
                    estacion = 2;
                    break;
                case 6:
                    estacion = 2;
                    break;
                case 7:
                    estacion = 3;
                    break;
                case 8:
                    estacion = 3;
                    break;
                case 9:
                    estacion = 3;
                    break;
                case 10:
                    estacion = 4;
                    break;
                case 11:
                    estacion = 4;
                    break;
                case 12:
                    estacion = 4;
                    break;
                case 0: 
                    default: Console.WriteLine("ERROR- mes inexistente\n");
                    break;
            }
            if (mes >= 1 && mes <= 3)
            {
                Console.WriteLine("El mes " + mes + " pertenece a la estacion " + estacion);
            }
                
        }
    }
}

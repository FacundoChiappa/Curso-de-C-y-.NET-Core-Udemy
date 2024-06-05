using System;

namespace curso_de_net //nombre del directorio donde se almacena el codigo
{
    class Program //clase de tipo programa que ejecuta la consola
    {
        static void Main(string[] args) // "static void" (metodo estatico que no retorna ninguna informacion) "Main (String [] args)" (nombre del metodo y demuestra que es del tipo array)
        {
            int year = 2024;  //variable de tipo entero que almacena un numero

            Console.WriteLine("Curso de C# y .Net");  //variable tipo string que almacena texto

            Console.WriteLine("Curso de C# y .NET realizado en el " + year); //concatenacion de string con entero mediante el "+"

            Console.WriteLine("Curso de C# y .NET realizado en el {0}" , year); //concatenacion de string con entero mediante el ","
                                                                                //y con el {0} se muestra la variable que le sigue a la coma
                                                                                //que en este caso es 0, si se pone otra coma y otro int, es el 1.

            int string_a_entero = Convert.ToInt16("2024");  //convertir datos del tipo string a entero con la cadena de valores .toint16
            double doble = 2.5; //dato de tipo double es para usar numero con coma
            decimal decimals = 2.5M; //otra forma de mostrar decimales, siempre va seguido del sufijo M para saber que es un decimal,
                                     //la M no se muestra
            float flotante = 8.5F;  //otra forma de mostrar decimales, siempre va seguido del sufijo F para saber que es un decimal,
                                    //la F no se muestra
            string nombre = "Facundo"; //dato de tipo string, no puedo poner numeros
            String nombres = "Facundo Nicolas"; //objeto de la clase string

            //float   7 digitos 32bits
            //double  15-16 digitos 64bits
            //decimal 28-29 digitos 128bits

            Console.WriteLine("Curso de C# y .NET realizado en el {0} en {1} horas por {2}", string_a_entero, decimals, nombres);


            bool valor = true;  //booleano que solo almaceba el valor de false
            char letra = 'A';  //solo puede almacer un solo caracter, siempre comilla simple, comilla doble solo para strings o cadenas de texto
            Decimal de = 9.6M;  //estructura para crear objetos del tipo decimales.  
            

            Console.WriteLine("Curso de C# y .NET realizado? {0}, calificacion del curso {1}, en numeros {2}", valor, letra, de);

            int valor2 = 3;
            int valor3 = 6;

            var suma = valor2 + valor3; //objeto local llamado suma creado con el var. si se le asigna operacion,
                                        //no se le debe dejar en claro si va a ser un resultado entero o no.
            var resta = valor2 - valor3; //objeto local llamado suma creado con el var. si se le asigna operacion,
                                        //no se le debe dejar en claro si va a ser un resultado entero o no.
            var multiplicacion = valor2 * valor3;
            var division = valor3 / valor2;

            Console.WriteLine(" Resultado suma = {0}, resultado resta = {1}, multiplicacion = {2}, division = {3}",suma, resta, multiplicacion, division);


            int valor9 = 1;
            int valor10 = 2;

            var valor4 = valor9 += valor10;  //incremento
            var valor5 = valor9 -= valor10;  //decremento
            var valor6 = valor9 *= valor10;  //multiplicacion
            var valor7 = valor9 /= valor10;  //division
            var valor8 = valor9 %= valor10;  //residuo de division

            Console.WriteLine("Resultado {0}", valor4);

            int valor11 = 4;
            int valor12 = 2;

            var data = valor11 < valor12;

            Console.WriteLine("Resultado {0}", data);
            Console.ReadLine(); //mantiene la consola abierta mientras se muestra el texto
        }

        

    }
}



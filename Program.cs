internal class Program
{
    private static void Main(string[] args)
    {
        string input, input2, palabra;

        Console.WriteLine("Ingrese una cadena de texto");
        input = Console.ReadLine();
        Console.WriteLine($"La longitud de la cadena ingresada es: {input.Length}");

        Console.WriteLine("Ingrese otra cadena de texto");
        input2 = Console.ReadLine();
        Console.WriteLine(input +" "+ input2);

        Console.WriteLine($"Los primeros 4 caracteres de la primer cadena son: '{input.Substring(0,4)}'");
        Console.WriteLine($"Los primeros 4 caracteres de la segunda cadena son: '{input2.Substring(0,4)}'");
        /*
        Utilizando la calculadora creada anteriormente realizar las operaciones de dosnúmeros y mostrar por pantalla y mostrar en texto el resultado.
        Por ejemplo parala suma sería:“la suma de “ num1 “ y de” num2 “ es igual a: ” resultado.
        !Este ejercicio ya lo realice dentro de la rama calculadora v1
        */

        Console.WriteLine("Recorriendo la cadena mediante foreach: ");
        foreach (var letra in input)
        {
            Console.Write(letra + " ");
        }

        Console.WriteLine("ingrese la palabra que desea buscar en la cadena:");
        palabra = Console.ReadLine();
        int indice = input.IndexOf(palabra,StringComparison.CurrentCultureIgnoreCase);
        if(indice != -1){
            Console.WriteLine($"Se encontro la palabra {palabra} en la posicion {indice+1} de la cadena {input}");
        }
        else{
            Console.WriteLine("no se encuentro la palabra");
        }
        
        Console.WriteLine($"La primera cadena en minúsculas queda: {input.ToLower()}");
        Console.WriteLine($"La segunda cadena en mayúsculas queda: {input2.ToUpper()}");

        Console.WriteLine("Ingrese una cadena separada por espacios");
        string input3 = Console.ReadLine();
        string[] palabras = input3.Split(" ");
        foreach(string letra in palabras){
            Console.WriteLine(letra);
        }
        Boolean error;
        do
        {          
            Console.WriteLine("----------Que desea calcular? (suma - resta -multiplicacion - divicion)----------");
            Console.WriteLine("ingrese una ecuacion:");
            string cadenaEcuacion = Console.ReadLine();
            error = true;
            int num1 = 0, num2 = 0;
            foreach(char caracter in cadenaEcuacion){
                if(caracter == '+'){
                    string[] cadenaEcuacionSeparada = cadenaEcuacion.Trim().Split('+');
                    if (int.TryParse(cadenaEcuacionSeparada[0],out num1) && int.TryParse(cadenaEcuacionSeparada[1],out num2))
                    {
                        Console.WriteLine($"El resultado es: {num1 + num2}");
                        error = false;
                        break;
                    }
                        Console.WriteLine("ERROR - Ingrese numeros validos");
                        break;
                }
                else if(caracter == '-'){
                    string[] cadenaEcuacionSeparada = cadenaEcuacion.Trim().Split('-');
                    if (int.TryParse(cadenaEcuacionSeparada[0],out num1) && int.TryParse(cadenaEcuacionSeparada[1],out num2))
                    {
                        Console.WriteLine($"El resultado es: {num1 - num2}");
                        error = false;
                        break;
                    }
                    Console.WriteLine("ERROR - Ingrese numeros validos");
                    break;
                }
                else if(caracter == '*'){
                    string[] cadenaEcuacionSeparada = cadenaEcuacion.Trim().Split('*');
                    if (int.TryParse(cadenaEcuacionSeparada[0],out num1) && int.TryParse(cadenaEcuacionSeparada[1],out num2))
                    {
                        Console.WriteLine($"El resultado es: {num1 * num2}");
                        error = false;
                        break;
                    }
                    Console.WriteLine("ERROR - Ingrese numeros validos");
                    break;
                }
                else if(caracter == '/'){
                    string[] cadenaEcuacionSeparada = cadenaEcuacion.Trim().Split('/');
                    if (int.TryParse(cadenaEcuacionSeparada[0],out num1) && int.TryParse(cadenaEcuacionSeparada[1],out num2))
                    {
                        if (num2 == 0)
                        {
                            Console.WriteLine("ERROR - No se puede dividir en 0");
                            break;
                        }
                        Console.WriteLine($"El resultado es: {num1 / num2}");
                        error = false;
                        break;
                    }
                    Console.WriteLine("ERROR - Ingrese numeros validos");
                    break;
                }
                
            }
        } while (error);
            
    }
        
}
internal class Program
{
    private static void Main(string[] args)
    {
        float num1, num2=0;
        float numero;
        string input;
        Boolean salir = false;
        Console.Clear();
        do
        {
            Console.WriteLine("--------------->");
            Console.WriteLine("---------------> Calculadora version 2.0");
            Console.WriteLine("--------------->");
            
            Console.WriteLine("Ingrese un numero: (utilice ',' para valores decimales)");

            input = Console.ReadLine();
            if (float.TryParse(input,out numero))
            {   
                Console.WriteLine($"El valor absoluto es: {Math.Abs(numero)}");
                Console.WriteLine($"El cuadrado es: {numero * numero}");
                Console.WriteLine($"El la raíz cuadrada es: {Math.Sqrt(numero)}");
                Console.WriteLine($"seno = {Math.Sin(numero)}");
                Console.WriteLine($"coceno = {Math.Cos(numero)}");
                Console.WriteLine($"La parte entera de {numero} es: {(int)(numero)}");

                Console.WriteLine("A continuacion Ingrese dos números para calcular el máximo y el mínimo");
                Boolean continuar = false;
                do
                {
                    Console.WriteLine("Ingrese el primer número (utilice ',' para valores decimales)");
                    input = Console.ReadLine();
                    if (!float.TryParse(input, out num1))
                    {
                        Console.Clear();
                        Console.WriteLine("ERROR - Intentelo de nuevo");
                        continue;
                    }
                    Console.WriteLine("Ingrese el segundo número (utilice ',' para valores decimales)");
                    input = Console.ReadLine();
                    if (!float.TryParse(input, out num2))
                    {
                        Console.Clear();
                        Console.WriteLine("ERROR - Intentelo de nuevo");
                        continue;
                    }
                    continuar = true;
                } while (!continuar);

                Console.WriteLine($"El valor máximo es: {Math.Max(num1,num2)}");
                Console.WriteLine($"El valor mínimo es: {Math.Min(num1,num2)}");

                do
                {
                    Console.WriteLine("Desea realizar otra operacion?  (y/n)");
                    input = Console.ReadLine();
                    if (input == "n" || input == "N")
                    {
                        Console.WriteLine("saliendo...");
                        salir = true;
                        break;
                    }else
                    {
                        if (!(input == "y" || input == "Y") )
                        {
                            Console.Clear();
                            Console.WriteLine("ERROR - Opción no válida");
                        }
                    }
                } while (!(input == "y" || input == "Y"));
                Console.Clear();
            }else
            {
                Console.Clear();
                Console.WriteLine("ERROR - Ingrese un número válido");
            }
            
        } while (!salir);
    }        
}
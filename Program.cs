internal class Program
{
    private static void Main(string[] args)
    {
        int opcion, num1, num2;
        string input;
        Boolean salir = false;
        Console.Clear();
        
        do
        {
            Console.WriteLine("--------------->");
            Console.WriteLine("---------------> Calculadora version 1.0");
            Console.WriteLine("--------------->");
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("0 - Salir");
            Console.WriteLine("Ingrese una opcion:");

            input = Console.ReadLine();
            if (int.TryParse(input,out opcion))
            {   
                if (opcion == 0)
                {
                    salir = true;
                    Console.WriteLine("Saliendo...");
                }
                if (opcion > 0 && opcion < 5)
                {
                    Console.WriteLine("Ingrese el primer número");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out num1))
                    {
                        Console.Clear();
                        Console.WriteLine("ERROR - Intentelo de nuevo");
                        continue;
                    }
                    Console.WriteLine("Ingrese el segundo número");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out num2))
                    {
                        Console.Clear();
                        Console.WriteLine("ERROR - Intentelo de nuevo");
                        continue;
                    }
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;
                        case 2:
                            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        break;
                        case 3:
                            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                        break;
                        case 4:
                            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        break;
                    }
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
                }else
                {
                    Console.Clear();
                    Console.WriteLine("ERROR - Opción no válida");
                }
            }else
            {
                Console.Clear();
                Console.WriteLine("ERROR - Opción no válida");
            }
            
        } while (!salir);
    }        
}
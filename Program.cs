internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        string input;
        Console.WriteLine("Ingrese un Número positivo");
        Boolean salir = false;
        do
        {
            input = Console.ReadLine();
            if (int.TryParse(input,out numero))
            {
                if (numero > 0)
                {
                    int numeroInvertido = 0, aux;
                    while (numero != 0)
                    {
                        aux = numero % 10;
                        numeroInvertido = numeroInvertido * 10 + aux;
                        numero /= 10;
                    }

                    Console.WriteLine($"El número invertido es: {numeroInvertido}");
                    salir = true;
                }else
                {
                    Console.WriteLine("ERROR - ingrese un Número positivo");
                }
            }else
            {
                Console.WriteLine("ERROR - Ingrese un Número");
            }   
        } while (!salir);
    }
}
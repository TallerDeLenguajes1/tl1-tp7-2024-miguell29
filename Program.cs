using EspacioCalculadora;
internal class Program
{
    private static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        String opcion;
        Double numero;
        Console.Clear();
        do
        {   
            Console.WriteLine("\tCalculadora V3");
            Console.WriteLine("Resultado = " + calc.Resultado);
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Limpiar");
            Console.WriteLine("0. Salir");
            Console.Write("Ingrese una opción: ");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                do
                {
                    Console.Write("Ingresar número: ");
                    if (double.TryParse(Console.ReadLine(), out numero))
                    {
                        calc.Sumar(numero);
                        Console.Clear();
                        Console.WriteLine("Resultado = " + calc.Resultado);
                        Console.WriteLine("1. Sumar otro número");
                        Console.WriteLine("2. Terminar operacion");
                        Console.Write("Ingrese una opción: ");
                        opcion = Console.ReadLine();
                        if (opcion != "2" && opcion != "1")
                        {
                            Console.Clear();
                            Console.WriteLine("ERROR - Opcion no válida");
                            break;
                        }
                    }
                    Console.Clear();
                } while (opcion == "1");
                break;

                case "2":
                do
                {
                    Console.Write("Ingresar número: ");
                    if (double.TryParse(Console.ReadLine(), out numero))
                    {
                        calc.Restar(numero);
                        Console.Clear();
                        Console.WriteLine("Resultado = " + calc.Resultado);
                        Console.WriteLine("1. Restar otro número");
                        Console.WriteLine("2. Terminar operacion");
                        Console.Write("Ingrese una opción: ");
                        opcion = Console.ReadLine();
                        if (opcion != "2" && opcion != "1")
                        {
                            Console.Clear();
                            Console.WriteLine("ERROR - Opcion no válida");
                            break;
                        }
                    }
                    Console.Clear();
                } while (opcion == "1");
                break;

                case "3":
                do
                {
                    Console.Write("Ingresar número: ");
                    if (double.TryParse(Console.ReadLine(), out numero))
                    {
                        calc.Multiplicar(numero);
                        Console.Clear();
                        Console.WriteLine("Resultado = " + calc.Resultado);
                        Console.WriteLine("1. Multiplicar otro número");
                        Console.WriteLine("2. Terminar operacion");
                        Console.Write("Ingrese una opción: ");
                        opcion = Console.ReadLine();
                        if (opcion != "2" && opcion != "1")
                        {
                            Console.Clear();
                            Console.WriteLine("ERROR - Opcion no válida");
                            break;
                        }
                    }
                    Console.Clear();
                } while (opcion == "1");
                break;
                case "4":
                do
                {
                    Console.Write("Ingresar número: ");
                    if (double.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.Clear();
                        calc.Dividir(numero);
                        Console.WriteLine("Resultado = " + calc.Resultado);
                        Console.WriteLine("1. Dividir otro número");
                        Console.WriteLine("2. Terminar operacion");
                        Console.Write("Ingrese una opción: ");
                        opcion = Console.ReadLine();
                        if (opcion != "2" && opcion != "1")
                        {
                            Console.Clear();
                            Console.WriteLine("ERROR - Opcion no válida");
                            break;
                        }
                    }
                    Console.Clear();
                } while (opcion == "1");

                break;
                case "5":
                Console.Clear();
                calc.Limpiar();

                break;
                case "0":
                    Console.WriteLine("Saliendo...");
                break;
            }

        } while (opcion != "0");
    }
}
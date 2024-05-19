
using EjercicioExcepciones;
using System.Diagnostics;

Operaciones operaciones = new Operaciones();
bool salir = false;
while (!salir)
{
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");
    Console.Write("Opción: ");
    string opcion = Console.ReadLine();

    try
    {
        double num1, num2;
        switch (opcion)
        {
            case "1":
                Console.WriteLine("Ingrese el Primer Numero: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el Segundo Numero: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Resultado: {operaciones.Suma(num1, num2)}");
                break;
            case "2":
                Console.WriteLine("Ingrese el Primer Numero: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el Segundo Numero: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Resultado: {operaciones.Resta(num1, num2)}");
                break;
            case "3":
                Console.WriteLine("Ingrese el Primer Numero: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el Segundo Numero: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Resultado: {operaciones.Multiplicacion(num1, num2)}");
                break;
            case "4":
                Console.WriteLine("Ingrese el Primer Numero: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el Segundo Numero: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Resultado: {operaciones.Divide(num1, num2)}");
                break;
            case "5":
                salir = true;
                break;
            default:
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Entrada no valida");
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine($"Error: {e.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error inesperado: {ex.Message}");
    }

 
}


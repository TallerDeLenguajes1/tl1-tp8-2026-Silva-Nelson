using EspacioCalculadora;

Calculadora calcular = new Calculadora();

string? entrada;
double num1, num2;
int opcion;


do
{
    Console.WriteLine("Ingrese un numero:");
    entrada = Console.ReadLine();
} while (!double.TryParse(entrada, out num1));
calcular.Dato = num1;

do
{
    Console.WriteLine("Ingrese un numero para la operacion que desee realizar");
    Console.WriteLine("0_ Sumar numeros");
    Console.WriteLine("1_ Restar numeros");
    Console.WriteLine("2_ Multiplicar numeros");
    Console.WriteLine("3_ Dividir numeros");
    Console.WriteLine("4_ Limpiar");
    entrada = Console.ReadLine();

    if (int.TryParse(entrada, out opcion))
    {
        do
        {    
            Console.WriteLine("Ingrese un numero:");
            entrada = Console.ReadLine();
        } while (!double.TryParse(entrada, out num2));
               
        switch (opcion)
        {
            case 0: 
                calcular.Sumar(num2);
            break;
            case 1:
                calcular.Restar(num2);
            break;
            case 2:
                calcular.Multiplicar(num2);
            break;
            case 3:
                calcular.Dividir(num2);
            break;
            case 4:
                calcular.Limpiar();
            break;
            default:
                Console.WriteLine("Algo salio mal.");
            break;
        } 
        Console.WriteLine($"El resultado es: {calcular.Resultado}");
    }else
    {
        Console.WriteLine("El dato ingresado no es valido.");   
    }

    Console.WriteLine("Si desea continuar con las operaciones ingrese un numero cualquiera para continuar.Ingrese una letra de lo contrario");
    entrada = Console.ReadLine();
} while (double.TryParse(entrada, out num1));

Console.WriteLine("\n📜 ============ HISTORIAL COMPLETO DE OPERACIONES ============");

// Usamos la propiedad "Listaperaciones" de tu calculadora para leer los tickets viejos
foreach (Operacion ticket in calcular.Listaoperaciones)
{
    // Usamos las propiedades get de la clase Operacion para imprimir cada renglón
    Console.WriteLine($"-> Operacion: {ticket.TipoOperacion} | Valor usado: {ticket.NuevoValor} | Resultado parcial: {ticket.Resultado}");
}
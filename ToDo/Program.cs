using Informacion;

List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();
Tarea? tareaEncontrada = null;//seria como un nodo aux

int n, x;
string? entrada;

do
{
    MostrarTareas.Menu();
    entrada = Console.ReadLine();
    int.TryParse(entrada, out n);
    switch (n)
    {
        case 1:
            do
            {
                Console.WriteLine("Ingrese la cantidad de tareas:");
                entrada = Console.ReadLine();    
            } while (!int.TryParse(entrada, out n));
            CargarTareas.ComenzarCarga(tareasPendientes, n);
        break;
        case 2:
            do
            {   
                Console.WriteLine("Ingrese la tarea que quiere marcar como realizada:");
                entrada = Console.ReadLine();
                CargarTareas.PasajeTareas(tareasPendientes, tareasRealizadas, entrada);
                Console.WriteLine("¿Desea realizar otra operacion?.Ingrese un numero para continuar");
                entrada = Console.ReadLine();
            } while (int.TryParse(entrada, out x));        
        break;
        case 3:        
            MostrarTareas.Mostrar(tareasPendientes);
        break;
        case 4:
            MostrarTareas.Mostrar(tareasRealizadas);
        break;
        case 5:
            do
            {
                Console.WriteLine("Ingrese la descripcion de la tarea que desea buscar:");
                entrada = Console.ReadLine();
                
                MostrarTareas.MostrarTareasIngresadas(tareasPendientes, entrada);

                Console.WriteLine("¿Desea realizar otra operacion?.Ingrese un numero para continuar");
                entrada = Console.ReadLine();
            } while (int.TryParse(entrada, out x));
        break;
        default:
            Console.WriteLine("Opcion no valida.");
        break;
    }
    Console.WriteLine("¿Desea realizar otra operacion del menu?. Ingrese un numero para continuar.");
    entrada = Console.ReadLine();
} while (int.TryParse(entrada, out n));

using Informacion;

List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();
Tarea? tareaEncontrada = null;//seria como un nodo aux

int n, x;
string? entrada;

do
{
    Console.WriteLine("Ingrese la cantidad de tareas:");
    entrada = Console.ReadLine();    
} while (!int.TryParse(entrada, out n));

for (int i = 0; i < n; i++)
{
    Tarea nuevaTarea = new Tarea();

    // Console.WriteLine("Ingrese la duracion de la tarea:");
    // entrada = Console.ReadLine();
    nuevaTarea.TareaId = i;

    Console.WriteLine("Ingrese una descripcion:");
    entrada = Console.ReadLine();
    nuevaTarea.Descripcion = entrada;
    do
    {
        Console.WriteLine("Ingrese la duracion de la tarea:");
        entrada = Console.ReadLine();   
    } while (!(int.TryParse(entrada, out x) && (x >= 10 && x <= 100)));

    nuevaTarea.Duracion = x;
    tareasPendientes.Add(nuevaTarea);
}

//mostramos los objetos cargados en la lista
Console.WriteLine();
Console.WriteLine("----- MOSTRAMOS LAS TAREAS -----");
Console.WriteLine();
for (int i = 0; i < tareasPendientes.Count; i++)
{
    Console.WriteLine($"ID : {tareasPendientes[i].TareaId}");
    Console.WriteLine($"DESCRIPCION : {tareasPendientes[i].Descripcion}");
    Console.WriteLine($"DURACION : {tareasPendientes[i].Duracion}");
}
Console.WriteLine();
Console.WriteLine("----- TAREAS REALIZADAS -----");
Console.WriteLine();

Console.WriteLine("¿Desea marcar una tarea como realizada?");
entrada = Console.ReadLine();
if (int.TryParse(entrada, out x))
{
    do
    {   
        Console.WriteLine("Ingrese la tarea que quiere marcar como realizada:");
        entrada = Console.ReadLine();
        foreach (Tarea t in tareasPendientes)
        {
            if (t.Descripcion == entrada)
            {
                tareaEncontrada = t;
            }
        }
        if (tareaEncontrada != null)
        {
            tareasPendientes.Remove(tareaEncontrada);//devuelve un booleano
            tareasRealizadas.Add(tareaEncontrada);
        }else
        { 
            Console.WriteLine("No se encontro la tarea.");
        }
        Console.WriteLine("¿Desea realizar otra operacion?.Ingrese un numero para continuar");
        entrada = Console.ReadLine();
    } while (int.TryParse(entrada, out x));

}
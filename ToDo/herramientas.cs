namespace Informacion
{
    public class Tarea
    {
        public int TareaId {get; set;}
        public string Descripcion { get; set; } 
        public int Duracion { get; set; }

    }

    public class CargarTareas
    {
        public static void ComenzarCarga(List<Tarea> t, int cant)
        {
            string? entrada;
            int x;

            for (int i = 0; i < cant; i++)
            {
                Tarea nuevaTarea = new Tarea();

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
                t.Add(nuevaTarea);
            }
        }

        public static void PasajeTareas(List<Tarea> pendientes, List<Tarea> realizadas, string entrada)
        {
            Tarea? tareaEncontrada = null;
            foreach (Tarea t in pendientes)
            {
                if (t.Descripcion == entrada)
                {
                    tareaEncontrada = t;
                }
            }
            if (tareaEncontrada != null)
            {
                pendientes.Remove(tareaEncontrada);//devuelve un booleano
                realizadas.Add(tareaEncontrada);
            }else
            { 
                Console.WriteLine("No se encontro la tarea.");
            }
        }
    }

    public class MostrarTareas
    {
        public static void Mostrar(List<Tarea> t)
        {
            Console.WriteLine();
            Console.WriteLine("----- MOSTRAMOS LAS TAREAS -----");
            Console.WriteLine();
            for (int i = 0; i < t.Count; i++)
            {
                Console.WriteLine($"ID : {t[i].TareaId}");
                Console.WriteLine($"DESCRIPCION : {t[i].Descripcion}");
                Console.WriteLine($"DURACION : {t[i].Duracion}");
            }
        }

        public static void MostrarTareasIngresadas(List<Tarea> pendientes, string entrada)
        {
            bool bandera = false;
            foreach ( Tarea t in pendientes)
            {
                if (t.Descripcion == entrada)
                {
                    bandera = true;
                    Console.WriteLine("La tarea ingresada es:");
                    Console.WriteLine($"ID : {t.TareaId}");
                    Console.WriteLine($"DESCRIPCION : {t.Descripcion}");
                    Console.WriteLine($"DURACION : {t.Duracion}");
                }
            }
            if (!bandera)
            {
                Console.WriteLine("No se encontro ninguna tarea con esa descripcion.");
            }
        }

        public static void Menu()
        {
            Console.WriteLine("Ingrese un numero para lo que desee realizar:");
            Console.WriteLine("1_ Cargar una tarea");
            Console.WriteLine("2_ Realizar una tarea");
            Console.WriteLine("3_ Mostrar tareas pendientes");
            Console.WriteLine("4_ Mostrar tareas realizadas");
            Console.WriteLine("5_ Buscar una tarea");
        }

    }
}
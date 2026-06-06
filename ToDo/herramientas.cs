namespace Informacion
{
    public class Tarea
    {
        public int TareaId {get; set;}
        public string Descripcion { get; set; } 
        public int Duracion { get; set; }


        // public bool Validacion(int dura)
        // {
        //     if (dura >= 10 && dura <= 100)
        //     {
        //         return true;
        //     }
        //     return false;
        // }

        // public Tarea(int tarea, string descripcion, int dura)
        // {
        //     this.TareaId = tarea;
        //     this.Descripcion = descripcion;
        //     this.Duracion = dura;
        // }
    }
}
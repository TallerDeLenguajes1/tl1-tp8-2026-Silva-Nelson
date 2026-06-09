namespace EspacioCalculadora
{
    public enum TipoOperacion{ 
       Suma, 
       Resta, 
       Multiplicacion, 
       Division, 
       Limpiar  // Representa la acción de borrar el resultado actual o el historial 
   } 
    public class Calculadora
    {
        private double dato;
        List<Operacion> ListaOperaciones = new List<Operacion>();
        public void Sumar(double termino)
        {
            Operacion nueva = new Operacion(dato, termino, TipoOperacion.Suma);
            dato += termino;
            ListaOperaciones.Add(nueva);
        }

        public void Restar(double termino)
        {
            Operacion nueva = new Operacion(dato, termino, TipoOperacion.Resta);
            dato -= termino;
            ListaOperaciones.Add(nueva);
        }

        public void Multiplicar(double termino)
        {
            Operacion nueva = new Operacion(dato, termino, TipoOperacion.Multiplicacion);
            dato *= termino;
            ListaOperaciones.Add(nueva);
        }

        public void Dividir(double termino)
        {
            Operacion nueva = new Operacion(dato, termino, TipoOperacion.Division);
            dato /= termino;
            ListaOperaciones.Add(nueva);
        }

        public void Limpiar()
        {
            Operacion nueva = new Operacion(dato, 0, TipoOperacion.Limpiar);
            dato = 0;
            ListaOperaciones.Add(nueva);
        }

        public double Resultado
        {
            get => dato;
        }
        
        public double Dato
        {
            set => dato = value;
        }

        public List<Operacion> Listaoperaciones
        {
            get => ListaOperaciones;
        }
    }

    public class Operacion{ 
        private double resultadoAnterior; // Almacena el resultado previo al cálculo actual 
        private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior 
        private TipoOperacion operacion;// El tipo de operación realizada 
        public double Resultado
        {
            get
            {
                double resultadoSalida;
                switch (operacion)
                {
                    case TipoOperacion.Suma:
                        resultadoSalida = resultadoAnterior + nuevoValor;
                    break;
                    case TipoOperacion.Resta:
                        resultadoSalida = resultadoAnterior - nuevoValor;
                    break;
                    case TipoOperacion.Multiplicacion:
                        resultadoSalida = resultadoAnterior * nuevoValor;
                    break;
                    case TipoOperacion.Division:
                        resultadoSalida = resultadoAnterior / nuevoValor;
                    break;
                    default:
                        resultadoSalida = 0;
                        break;
                }
                return resultadoSalida; 
            }
        } 
        public double NuevoValor
        {
            get => nuevoValor;
        }
        public TipoOperacion TipoOperacion
        {
            get => operacion;
        }
        public Operacion(double ResultadoAnterior, double NuevoValor_constructor, TipoOperacion Operacion)
        {
            this.resultadoAnterior = ResultadoAnterior;
            this.nuevoValor = NuevoValor_constructor;
            this.operacion = Operacion;
        }
    } 
}

using System;
using System.Collections.Generic;
using CP3.Helpers;

namespace CP3
{
    static class Constantes {
        public enum TipoDeIdentificacion
        {
            DNI = 1,
            Pasaporte = 2,
            LibretaCivica = 3
        };
        public enum CursoInscripto
        {
            ArtesPlasticas = 1,
            ArteDigital = 2,
            DisenioGrafico = 3
        };
        public static DateTime hoy = DateTime.Now;
        public static string[] nombres = { "Pablo", "Pedro", "Marta", "Natalia", "Victoria", "Constanza" };
        public static string ruta = @"B:\C#\CONTROLES\CP3\bin\Debug\LISTADOS\";
    }
    class Program
    {

        static void Main(string[] args)
        {
            List<Alumno> alumnos = new List<Alumno>();
            int cond = 0;

            do {
                Console.WriteLine("1 CARGAR ALUMNOS\n2 MOSTRAR ALUMNOS\n3 IMPRIMIR ALUMNOS:\n");
                cond = Convert.ToInt32(Console.ReadLine());
                if (cond == 1) {
                    //alumnos.Add();
                    Alumno aux = new Alumno();
                    for (int i = 0; i < 15; i++) {
                        aux = cargarDatoAlumno();
                        alumnos.Add(aux);
                        Console.Clear();
                    }
                    Mostrar(alumnos);
                }
                else if (cond == 2) {
                    Mostrar(alumnos);
                } else if (cond == 3) {
                    HelperDeArchivos.CargarArchivo(Constantes.ruta, alumnos);
                }
            } while (cond != 0);

        }
        public static void Mostrar(List<Alumno> alumnos){
            Console.Clear();
            for (int i = 0; i < alumnos.Count; i++) {
                Console.WriteLine(alumnos[i].Nombre);
                Console.WriteLine(alumnos[i].Nacimiento.ToString("yyyy-MM-dd"));
                Console.WriteLine(alumnos[i].Mensualidad);
                Console.WriteLine(alumnos[i].Curso_inscripto);
            }
        }
        public static Alumno cargarDatoAlumno() {
            var rand = new Random();
            Alumno aux = new Alumno();
            int diaNac; int mesNac; int anioNac;
            float cuota = 1500f;
            cuota = cuota * 1.21f;

            Console.WriteLine("ID: ");
            aux.Id = Convert.ToInt32(Console.ReadLine());
            aux.Nombre = Constantes.nombres[rand.Next(5)];
            Console.WriteLine("ANIO INSC (AAAA): ");
            aux.Anio_inscripcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DIA NAC: "); diaNac = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("MES NAC: "); mesNac = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ANIO NAC: "); anioNac = Convert.ToInt32(Console.ReadLine());

            aux.Nacimiento = new DateTime(anioNac, mesNac, diaNac);

            aux.Curso_inscripto = ((Constantes.CursoInscripto)rand.Next(1,4)).ToString();

            aux.Edad = Constantes.hoy.Year - aux.Nacimiento.Year;

            if (rand.Next(2) == 1) {
                aux.Regular = true;
            }else { aux.Regular = false; }

            if (aux.Regular == true && aux.Anio_inscripcion == Constantes.hoy.Year)
            {
                cuota = cuota * 0.8f;
            }
            else if (aux.Regular == true || aux.Anio_inscripcion == Constantes.hoy.Year)
            {
                cuota = cuota * 0.9f;
            }
            aux.Mensualidad = cuota;

            return aux;
        }
    }
}

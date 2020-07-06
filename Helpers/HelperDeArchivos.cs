using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.IO;

namespace CP3.Helpers
{
    public static class HelperDeArchivos
    {

        public static void CargarArchivo(string NombreDeArchivo, List<Alumno> alumnos) {
            string ruta = NombreDeArchivo;
            string txtSTR = "";
            for (int i = 0; i < alumnos.Count; i++) {
            txtSTR = alumnos[i].Id.ToString() + ";" + alumnos[i].Nombre + ";" + alumnos[i].Anio_inscripcion.ToString() + ";" + alumnos[i].Nacimiento.ToString("yyyy-MM-dd") + ";" + alumnos[i].Curso_inscripto + ";" + alumnos[i].Edad.ToString() + ";" + alumnos[i].Mensualidad.ToString() + ";" + alumnos[i].Regular.ToString();
                if (alumnos[i].Curso_inscripto == "ArtesPlasticas") {
                    using (Stream fs = new FileStream(ruta+ "ArtesPlasticas.csv", FileMode.Append, FileAccess.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(fs)) {
                            sw.WriteLine(txtSTR);
                        }
                    }

                    }else if (alumnos[i].Curso_inscripto == "ArteDigital") {
                    using (Stream fs2 = new FileStream(ruta+ "ArteDigital.csv", FileMode.Append, FileAccess.Write))
                    {
                        using (StreamWriter sw2 = new StreamWriter(fs2))
                        {
                            sw2.WriteLine(txtSTR);
                        }
                    }
                }
                else if (alumnos[i].Curso_inscripto == "DisenioGrafico") {
                    
                    using (Stream fs3 = new FileStream(ruta+ "DisenioGrafico.csv", FileMode.Append, FileAccess.Write))
                    {
                        using (StreamWriter sw3 = new StreamWriter(fs3))
                        {
                            sw3.WriteLine(txtSTR);
                        }
                    }                    

                }
            }
        }
    }
}

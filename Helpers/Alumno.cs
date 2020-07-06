using System;
using System.Collections.Generic;
using System.Text;

namespace CP3.Helpers
{
    public class Alumno
    {
        private int id;
        private string nombre;
        private int anio_inscripcion;
        private DateTime nacimiento;
        private string curso_inscripto;
        private int edad;
        private float mensualidad;
        private bool regular;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Anio_inscripcion { get => anio_inscripcion; set => anio_inscripcion = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
        public string Curso_inscripto { get => curso_inscripto; set => curso_inscripto = value; }
        public int Edad { get => edad; set => edad = value; }
        public float Mensualidad { get => mensualidad; set => mensualidad = value; }
        public bool Regular { get => regular; set => regular = value; }
    }
}

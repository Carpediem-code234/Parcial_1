using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1.entidad
{
    public class Estudiante
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public double PromedioNotas { get; set; }


        public Estudiante(string nombres, string apellidos, int edad, string sexo, double promedioNotas)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Edad = edad;
            Sexo = sexo;
            PromedioNotas = promedioNotas;
        }
        
        public string ObtenerEstado()
        {
            return $"{Nombres} {Apellidos} , {Edad} años, Sexo: {Sexo}, Promedio: {PromedioNotas}";
        }

    }
}

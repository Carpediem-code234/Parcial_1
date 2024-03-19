using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Parcial_1.entidad
{
    public class Grupo
    {
        // Atributos
        public string NombreGrupo { get; set; }
        public List<Estudiante> estudiantes;

        // Constructor
        public Grupo(string nombreGrupo)
        {
            NombreGrupo = nombreGrupo;
            estudiantes = new List<Estudiante>();
        }

        
        public void AgregarEstudiante(Estudiante estudiante)
        {

            if (!Pertenencia(estudiante))
            {   
                Console.WriteLine($"Estudiante '{estudiante.Nombres} {estudiante.Apellidos}' agregado al grupo '{NombreGrupo}'.");
                estudiantes.Add(estudiante);
            }
            else
            {
                Console.WriteLine($"El estudiante '{estudiante.Nombres} {estudiante.Apellidos}' ya existe en el grupo '{NombreGrupo}'.");
            }
        }

        
        public bool Pertenencia(Estudiante estudiante)
        {
            foreach (Estudiante e in estudiantes)
            {
                if (e.Nombres == estudiante.Nombres && e.Apellidos == estudiante.Apellidos)
                {
                    return true;
                }
            }
            return false;
        }

        public void ImprimirEstudiantes()
        {
            Console.WriteLine($"Estudiantes del grupo '{NombreGrupo}':");
            foreach (Estudiante e in estudiantes)
            {
                Console.WriteLine(e.ObtenerEstado());
            }
        }
    }
}

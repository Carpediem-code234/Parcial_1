using Parcial_1.entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1.logica
{
    public class OperacionesGrupo
    {
         
            public  Grupo Union(Grupo grupo1, Grupo grupo2)
            {
                Grupo resultado = new Grupo($"Union({grupo1.NombreGrupo}, {grupo2.NombreGrupo})");

                foreach (Estudiante e in grupo1.estudiantes)
                {
                    resultado.AgregarEstudiante(e);
                }

                foreach (Estudiante e in grupo2.estudiantes)
                {
                    resultado.AgregarEstudiante(e);
                }

                return resultado;
            }
            
            public Grupo Interseccion(Grupo grupo1, Grupo grupo2)
            {
                Grupo resultado = new Grupo($"Interseccion({grupo1.NombreGrupo}, {grupo2.NombreGrupo})");

                foreach (Estudiante e in grupo1.estudiantes)
                {
                    if (grupo2.Pertenencia(e))
                    {
                        resultado.AgregarEstudiante(e);
                    }
                }

                return resultado;
            }
          
            public Grupo Diferencia(Grupo grupo1, Grupo grupo2)
            {
                Grupo resultado = new Grupo($"Diferencia({grupo1.NombreGrupo}, {grupo2.NombreGrupo})");

                foreach (Estudiante e in grupo1.estudiantes)
                {
                    if (!grupo2.Pertenencia(e))
                    {
                        resultado.AgregarEstudiante(e);
                    }
                }

                return resultado;
            }
        
    }
}

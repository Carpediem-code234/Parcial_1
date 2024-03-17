using Parcial_1.entidad;
using Parcial_1.logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1.interfaz
{
    public class Menu
    {
        public void Menuprincipal()
        {
            bool salir = false;
            List<Grupo> grupos = new List<Grupo>();
            

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== Menú Principal ===");
                Console.WriteLine("1. Crear grupo");
                Console.WriteLine("2. Agregar estudiante a un grupo");
                Console.WriteLine("3. Ver estudiantes de un grupo");
                Console.WriteLine("4. Realizar operaciones entre grupos");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Ingrese el nombre del grupo: ");
                        string nombreGrupo = Console.ReadLine();
                        Grupo nuevoGrupo = new Grupo(nombreGrupo);
                        grupos.Add(nuevoGrupo);
                        Console.WriteLine($"Grupo '{nombreGrupo}' creado.");
                        Console.ReadKey();
                        break;
                    case "2":
                        if (grupos.Count == 0)
                        {
                            Console.WriteLine("No hay grupos creados. Cree un grupo primero.");
                            Console.ReadKey();
                            break;
                        }
                        Console.Clear();
                        Console.WriteLine("Grupos disponibles:");
                        for (int i = 0; i < grupos.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {grupos[i].NombreGrupo}");
                        }
                        Console.Write("Seleccione el número de grupo al que desea agregar un estudiante: ");
                        int indiceGrupo = int.Parse(Console.ReadLine()) - 1;

                        Console.Write("Ingrese el nombre del estudiante: ");
                        string nombreEstudiante = Console.ReadLine();
                        Console.Write("Ingrese el apellido del estudiante: ");
                        string apellidoEstudiante = Console.ReadLine();
                        Console.Write("Ingrese la edad del estudiante: ");
                        int edadEstudiante = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el sexo del estudiante (M/F): ");
                        string sexoEstudiante = Console.ReadLine();
                        Console.Write("Ingrese el promedio de notas del estudiante: ");
                        double promedioNotasEstudiante = double.Parse(Console.ReadLine());

                        Estudiante nuevoEstudiante = new Estudiante(nombreEstudiante, apellidoEstudiante, edadEstudiante, sexoEstudiante, promedioNotasEstudiante);
                        grupos[indiceGrupo].AgregarEstudiante(nuevoEstudiante);
                        Console.ReadKey();
                        break;
                    case "3":
                        if (grupos.Count == 0)
                        {
                            Console.WriteLine("No hay grupos creados. Cree un grupo primero.");
                            Console.ReadKey();
                            break;
                        }
                        Console.Clear();
                        Console.WriteLine("Grupos disponibles:");
                        for (int i = 0; i < grupos.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {grupos[i].NombreGrupo}");
                        }
                        Console.Write("Seleccione el número de grupo del que desea ver los estudiantes: ");
                        int indiceGrupoEstudiantes = int.Parse(Console.ReadLine()) - 1;
                        grupos[indiceGrupoEstudiantes].ImprimirEstudiantes();
                        Console.ReadKey();
                        break;
                    case "4":
                        
                        if (grupos.Count < 2)
                        {
                            Console.WriteLine("Debe haber al menos dos grupos para realizar operaciones entre grupos.");
                            Console.ReadKey();
                            break;
                        }
                        Console.Clear();
                        Console.WriteLine("Grupos disponibles:");
                        for (int i = 0; i < grupos.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {grupos[i].NombreGrupo}");
                        }
                        Console.Write("Seleccione el número del primer grupo: ");
                        int indiceGrupo1 = int.Parse(Console.ReadLine()) - 1;
                        Console.Write("Seleccione el número del segundo grupo: ");
                        int indiceGrupo2 = int.Parse(Console.ReadLine()) - 1;

                        Console.WriteLine("Seleccione la operación:");
                        Console.WriteLine("1. Unión");
                        Console.WriteLine("2. Intersección");
                        Console.WriteLine("3. Diferencia (M - N)");
                        string operacion = Console.ReadLine();

                        OperacionesGrupo operaciones = new OperacionesGrupo();
                        Grupo resultadoOperacion = null;
                        switch (operacion)
                        {
                            case "1":
                                
                                resultadoOperacion = operaciones.Union(grupos[indiceGrupo1], grupos[indiceGrupo2]);
                                break;
                            case "2":
                                
                                resultadoOperacion = operaciones.Interseccion(grupos[indiceGrupo1], grupos[indiceGrupo2]);
                                break;
                            case "3":
                                resultadoOperacion = operaciones.Diferencia(grupos[indiceGrupo1], grupos[indiceGrupo2]);
                                break;
                            default:
                                Console.WriteLine("Opción no válida.");
                                break;
                        }

                        if (resultadoOperacion != null)
                        {
                            Console.WriteLine("Resultado de la operación:");
                            resultadoOperacion.ImprimirEstudiantes();
                        }
                        Console.ReadKey();
                        break;
                    case "5":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");

                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

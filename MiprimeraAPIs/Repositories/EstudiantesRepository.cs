using MiprimeraAPIs.Models;

namespace MiprimeraAPIs.Repositories
{
    public class EstudiantesRepository
    {
        public Estudiante DevuelveInformacionEstudiante()
        {
            Estudiante estudiante = new Estudiante
            {
                Id = 1,
                Nombre = "Santiago",
                Edad = 30,
                FechaNacimiento = DateTime.Now,
                EstaInscrito = true
            };
            return estudiante;
        }
        public List<Estudiante> DevuelveListadoEstudiantes()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            estudiantes.Add(new Estudiante
            {
                Id = 1,
                Nombre = "Santiago",
                Edad = 30,
                FechaNacimiento = DateTime.Now,
                EstaInscrito = true
            });

            estudiantes.Add(new Estudiante
            {
                Id = 2,
                Nombre = "Jose",
                Edad = 20,
                FechaNacimiento = DateTime.Now,
                EstaInscrito = false
            });
            return estudiantes;

        }
    }
}

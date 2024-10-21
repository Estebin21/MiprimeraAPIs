using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiprimeraAPIs.Models;
using MiprimeraAPIs.Repositories;

namespace MiprimeraAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        [Route("InformacionEstudiante")]
        [HttpGet]
        
        public Estudiante DevuelveInformacionEstudiante()
        {
            EstudiantesRepository repositorio = new EstudiantesRepository();
            var estudiante = repositorio.DevuelveInformacionEstudiante();
            return estudiante;
        }

        [Route("ListadoEstudiantes")]
        [HttpGet]
        public List<Estudiante> DevuelveListadoEstudiantes()
        {
            EstudiantesRepository repositorio = new EstudiantesRepository();
            return repositorio.DevuelveListadoEstudiantes();
        }

        [Route("ListadoEstudiantesInscritos")]
        [HttpGet]
        public List<Estudiante> DevuelveListadoEstudiantesInscritos()
        {
            EstudiantesRepository repositorio = new EstudiantesRepository();
            return repositorio.DevuelveListadoEstudiantes().Where(x => x.EstaInscrito == true).ToList();
        }
    }
}

namespace MiprimeraAPIs.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Boolean EstaInscrito { get; set; } 
        public int Edad {  get; set; }
    }
}

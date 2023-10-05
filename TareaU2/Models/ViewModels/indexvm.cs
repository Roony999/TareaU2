namespace TareaU2.Models.ViewModels
{
    public class indexvm
    {
        public List<animalcl> AnimalCLS { get; set; } = null!;
    }

    public class animalcl
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string descripcion { get; set; }
    }
}
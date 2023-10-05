namespace TareaU2.Models.ViewModels
{
    public class EspeciesVM
    {
        public int? id { get; set; }
        public string nombre { get; set; }
        public List<Especiec> Especiesls { get; set; }
    }
    public class Especiec
    {
        public int Id { get; set; }
        public int? idclase { get; set; }
        public string Especie { get; set; }
    }
}

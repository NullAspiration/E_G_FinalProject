namespace E_G_FinalProject.Models.Entities
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Sprites { get; set; } 
        public string Type { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public  ICollection<string> Types { get; set; } = new List<string>();
        public ICollection<string> Sptites { get; set; } = new List<string>();


    }
}

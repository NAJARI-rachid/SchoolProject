namespace DAL.Models
{
    public class Etudiant
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; } = null!;
    
    }
}
public class CreatEtudiantDto()
{
    public string Name { get; set; } 
    public string Email { get; set; } 
}
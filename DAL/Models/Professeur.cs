namespace DAL.Models
{
    public class Professeur
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; } = null!;
        public List<Etudiant> Etudiants { get; set; } = new List<Etudiant>();
    }
}
public class CreatProfesseurDto()
{
    public string Name { get; set; } 
    public string Email { get; set; } 
}
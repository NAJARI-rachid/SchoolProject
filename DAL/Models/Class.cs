namespace DAL.Models

{
    public class Class
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public required string Promo { get; set; }
        public List<Etudiant> Etudiants { get; set; } = new List<Etudiant>();
    }
}
public class CreatClasseDto()
{
    public string Name { get; set; } 
    public string Promo { get; set; } 
}
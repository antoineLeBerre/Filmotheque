namespace Filmotheque.Models.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public string Email { get; set; }
    }
}
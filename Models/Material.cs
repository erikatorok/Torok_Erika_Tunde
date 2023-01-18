namespace Torok_Erika_Tunde.Models
{
    public class Material
    {
        public int ID { get; set; }
        public string MaterialName { get; set; }
        public ICollection<Client>? Clienti { get; set; } //navigation property
    }
}

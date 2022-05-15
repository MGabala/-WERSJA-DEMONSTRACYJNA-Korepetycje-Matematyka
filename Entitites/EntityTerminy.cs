namespace Korepetycje_Matematyka.Entitites
{
    public class EntityTerminy
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Poniedziałek { get; set; }
        public string Wtorek { get; set; }
        public string Środa { get; set; }
        public string Czwartek { get; set; }
        public string Piątek { get; set; }
        public string Sobota { get; set; }
        public string Niedziela { get; set; }
    }
}

namespace Korepetycje_Matematyka.Entitites
{
    public class EntityTerminy
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Dzień_Tygodnia { get; set; }
        public string Godzina { get; set; }
        public string Godzina1 { get; set; }
        public string Godzina2 { get; set; }
        public string Godzina3 { get; set; }
        public string Godzina4 { get; set; }
        public string Godzina5 { get; set; }
        public string Godzina6 { get; set; }
        public string Godzina7 { get; set; }
        public string Godzina8 { get; set; }
        public string Godzina9 { get; set; }
    }
}

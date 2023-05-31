namespace Mubasa.Models
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Id_Ghn { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
    }
}
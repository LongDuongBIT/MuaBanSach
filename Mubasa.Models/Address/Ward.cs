namespace Mubasa.Models
{
    public class Ward
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Id_Ghn { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace SpaceAgencyado.Model
{
    public class Mission
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string country { get; set; }

        public string agency_nm { get; set; }
    }
}

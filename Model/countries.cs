using System.ComponentModel.DataAnnotations;

namespace SpaceAgencyado.Model
{
    public class countries
    {
        [Key]
        public int country_id { get; set; }
        public string name { get; set; }
    }
}

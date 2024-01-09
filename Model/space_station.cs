using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SpaceAgencyado.Model
{
    public class space_station
    {
        [Key]
        public int st_id { get; set; }
        public string st_name { get; set; }

        public countries countries { get; set; }

        [ForeignKey("countries")]
        public int st_country { get; set; }
    }
}

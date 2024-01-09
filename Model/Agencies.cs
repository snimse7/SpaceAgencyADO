using SpaceAgencyado.Interface;
using System.ComponentModel.DataAnnotations;

namespace SpaceAgencyado.Model
{
    public class Agencies 
    {
        public int id { get; set; }

        [Required(ErrorMessage = "name is required.")]
        [MinLength(1, ErrorMessage = "name must be at least 4 characters long.")]
        [MaxLength(50, ErrorMessage = "name must be at least 50 characters long.")]
        public string name { get; set; }

        [Required(ErrorMessage = "name is required.")]
        [MinLength(1, ErrorMessage = "name must be at least 4 characters long.")]
        [MaxLength(50, ErrorMessage = "name must be at least 50 characters long.")]
        public string fullform { get; set; }

        [Required(ErrorMessage = "name is required.")]
        [MinLength(1, ErrorMessage = "name must be at least 4 characters long.")]


        public string country { get; set; }

        [Required(ErrorMessage = "name is required.")]
        [MinLength(1, ErrorMessage = "name must be at least 4 characters long.")]
        [MaxLength(50, ErrorMessage = "name must be at least 50 characters long.")]
        public string budget { get; set; }

        [Required(ErrorMessage = "name is required.")]
        [MinLength(1, ErrorMessage = "name must be at least 4 characters long.")]

        public string establishment { get; set; }

        [Required(ErrorMessage = "name is required.")]
        [MinLength(1, ErrorMessage = "name must be at least 4 characters long.")]
        [MaxLength(50, ErrorMessage = "name must be at least 50 characters long.")]
        public string founder { get; set; }

        [Required(ErrorMessage = "name is required.")]
        [MinLength(1, ErrorMessage = "name must be at least 4 characters long.")]

        public string launchstation { get; set; }

        [Required(ErrorMessage = "name is required.")]
        [MinLength(1, ErrorMessage = "name must be at least 4 characters long.")]

        public string majorprojects { get; set; }

        [Required(ErrorMessage = "name is required.")]
        [MinLength(1, ErrorMessage = "name must be at least 4 characters long.")]

        public string recentproject { get; set; }

        [Required(ErrorMessage = "name is required.")]
        [MinLength(1, ErrorMessage = "name must be at least 4 characters long.")]

        public string upcomingprojects { get; set; }

        [Required(ErrorMessage = "name is required.")]
        [MinLength(1, ErrorMessage = "name must be at least 4 characters long.")]

        public string owner { get; set; }

        [Required(ErrorMessage = "name is required.")]
        [MinLength(1, ErrorMessage = "name must be at least 4 characters long.")]

        public string type { get; set; }

        [Required(ErrorMessage = "name is required.")]
        [MinLength(1, ErrorMessage = "name must be at least 4 characters long.")]

        public string picture { get; set; }

    }
}

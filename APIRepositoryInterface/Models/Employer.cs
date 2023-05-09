using System.ComponentModel.DataAnnotations;

namespace APIRepositoryInterface.Models
{
    public class Employer
    {
        [Key]
        public int id { get; set; }

        public string Name { get; set; }

        public string JobTitle { get; set; }

    }
}

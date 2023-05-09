using System.ComponentModel.DataAnnotations;

namespace APIRepositoryInterface.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }

        public string Name { get; set; }

        public string ApplyingPosition { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace NhdLab06.Models
{
    public class NhdEmployee
    {
        [Key]
        public int NhdId { get; set; }

        [Required]
        [StringLength(100)]
        public string NhdName { get; set; }

        [DataType(DataType.Date)]
        public DateTime NhdBirthDay { get; set; }

        [Required]
        [EmailAddress]
        public string NhdEmail { get; set; }

        [Required]
        [Phone]
        public string NhdPhone { get; set; }

        [Range(0, double.MaxValue)]
        public decimal NhdSalary { get; set; }

        public bool NhdStatus { get; set; }  // true: đang làm, false: nghỉ việc
    }
}

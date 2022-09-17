using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RapeCrisisCounsellorSystem.Models
{
    public class Counsellor
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CounsellorId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [Display(Name = "First Language")]
        public string FirstLanguage { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public Gender gender { get; set; }

        public enum Gender
        {
            Male = 0,
            Female = 1,
            Other = 2
        }

        [Required]
        public string Description { get; set; }


    }
}

using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RapeCrisisCounsellorSystem.Models
{
    public class Schedule
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int CounsellorId { get; set; }

        public Counsellor Counsellor { get; set; }

        [Required]
        [Display(Name = "Appointment Date")]
        [BindProperty, DataType(DataType.Date)]
       
        public DateTime AvailableDate { get; set; }

        [Required]
        [Display(Name = "Start Time")]
        [BindProperty, DataType(DataType.Time)]
       
        public DateTime startTime { get; set; }

        [Required]
        [Display(Name = "End Time")]
        [BindProperty, DataType(DataType.Time)]
      
        public DateTime endTime { get; set; }

        public IList<Counsellor> counsellors;
    }
}

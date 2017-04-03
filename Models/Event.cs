using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ZenithWebsite.Models.CustomValidation;

namespace ZenithWebsite.Models
{
    public class Event
    {
        [Display(Name = "Event ID")]
        public int EventId { get; set; }
        // [DisplayFormat(DataFormatString = "{0:h:mm tt}")]

        [Required(ErrorMessage = "Events must have a starting time.")]
        [Display(Name = "Starting Time")]
        public DateTime EventFrom { get; set; }

        [Required(ErrorMessage = "Events must have an ending time.")]
        [Display(Name = "Ending time")]
        [StartEndDateValidator]
        public DateTime EventTo { get; set; }

        [Display(Name = "Creator")]
        public string EnteredBy { get; set; }

        [Display(Name = "Activity")]
        public int ActivityId { get; set; }

        [Display(Name = "Date Created")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Active?")]
        public bool IsActive { get; set; }

        public virtual Activity Activity { get; set; }
    }
}

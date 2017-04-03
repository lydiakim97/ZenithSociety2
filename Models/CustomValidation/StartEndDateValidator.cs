using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithWebsite.Models.CustomValidation
{
    class StartEndDateValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = (Models.Event)validationContext.ObjectInstance;
            DateTime EndTime = Convert.ToDateTime(value);
            DateTime StartTime = Convert.ToDateTime(model.EventFrom);

            int EndDay = EndTime.Day;
            int StartDay = StartTime.Day;

            if (EndDay != StartDay)
            {
                return new ValidationResult("Start Day and End Day must be on the same day.");
            }
            else if (StartTime >= EndTime)
            {
                return new ValidationResult("End Time must be greater than Start Time.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }

    }

}
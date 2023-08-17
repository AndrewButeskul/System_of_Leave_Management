using LeaveManagementWeb.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementWeb.Models
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
        [Required]
        [Display(Name ="Date of Start")]
        public DateTime? StartDate { get; set; }

        [Required]
        [Display(Name = "Date of Expiry")]
        public DateTime? DateOfExpiry { get; set; }

        [Display(Name = "Leave Type ID")]
        [Required]
        public int LeaveTypeId { get; set; }
        public SelectList? LeaveTypes { get; set; }

        [Display(Name = "Comment")]
        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartDate > DateOfExpiry)
            {
                yield return new ValidationResult("The Date of Start cannot be after the Date of Expiry",
                    new[] { nameof(StartDate), nameof(DateOfExpiry) });
            }

            if(RequestComments?.Length > 250)
            {
                yield return new ValidationResult("The the length of comment is large",new[] { nameof(RequestComments) });
            }
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWeb.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Quantity of days by default")]
        [Required]
        [Range(1,24, ErrorMessage = "Please, fill in a valid range")]
        public int DefaultDays { get; set; }

    }
}

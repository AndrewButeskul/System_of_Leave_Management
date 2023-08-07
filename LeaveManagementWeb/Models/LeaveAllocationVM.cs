using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWeb.Models
{
    public class LeaveAllocationVM
    {
        [Required]  
        public int Id { get; set; }
        [Display(Name = "Number of days")]
        [Required]
        [Range(1,30, ErrorMessage ="Invalid entered value")]
        public int NumberOfDays { get; set; }

        [Required]
        [Display(Name = "Allocation period")]
        public int Period { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }

    }
}
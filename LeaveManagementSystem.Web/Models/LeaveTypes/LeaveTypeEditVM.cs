using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeEditVM : BaseLeaveTypeVM
    {
        [Required]
        [Length(4, 150, ErrorMessage = "Length requirement violation: leave type name must be at least 4 characters and no more than 150 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(1, 180)]
        [Display(Name = "Number of Days")]
        public int NumberOfDays { get; set; }
    }
}

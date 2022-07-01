using amr_project.Data;
using System.ComponentModel.DataAnnotations;
using static amr_project.Models.LeaveTypeVM;

namespace amr_project.Models
{
    public class LeaveAllocationVM
    {
        public int Id { get; set; }
        [Required]
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }

        public Employee Employee { get; set; }
        public string EmployeeId { get; set; }

        public DetailsLeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
    }
}


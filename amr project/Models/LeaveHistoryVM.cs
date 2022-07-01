using amr_project.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using static amr_project.Models.LeaveTypeVM;
using System.ComponentModel.DataAnnotations;

namespace amr_project.Models
{
    public class LeaveHistoryVM
    {
        public int Id { get; set; }

        public Employee RequestingEmployee { get; set; }
        public string RequestingEmployeeId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public DetailsLeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public IEnumerable<SelectListItem> LeaveTypes { get; set; }

        public DateTime DateRequested { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }

        public Employee ApprovedBy { get; set; }
        public string ApprovedById { get; set; }
    }
}


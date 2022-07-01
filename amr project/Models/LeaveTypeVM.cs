using System.ComponentModel.DataAnnotations;

namespace amr_project.Models
{
    public class LeaveTypeVM
    {
        public class DetailsLeaveTypeVM
        {
            public int Id { get; set; }
            public string ? Name { get; set; }
            public DateTime DateCreated { get; set; }
        }
        public class CreateLeaveTypeVM
        {
            [Required]
            public string Name { get; set; }
        }
    }
}

using amr_project.Data;
using amr_project.Models;
using AutoMapper;
using static amr_project.Models.LeaveTypeVM;

namespace amr_project.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Employee, EmployeeVM>().ReverseMap();
            CreateMap<LeaveType, DetailsLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveHistory, LeaveHistoryVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();



        }
    }
}

using amr_project.Data;

namespace amr_project.Contract
{
    public interface ILeaveType :IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeeByLeaveType(int id);

    }
}

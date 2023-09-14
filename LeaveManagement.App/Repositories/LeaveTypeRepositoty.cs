using LeaveManagement.App.Contracts;
using LeaveManagement.Data;

namespace LeaveManagement.App.Repositories
{
    public class LeaveTypeRepositoty : GenericRepository<LeaveType>, ILeaveTypeRepository 
    {
        public LeaveTypeRepositoty(ApplicationDbContext contex) : base(contex)
        {

        }
    }
}

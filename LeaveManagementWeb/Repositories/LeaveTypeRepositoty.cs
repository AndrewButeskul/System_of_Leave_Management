using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;

namespace LeaveManagementWeb.Repositories
{
    public class LeaveTypeRepositoty : GenericRepository<LeaveType>, ILeaveTypeRepository 
    {
        public LeaveTypeRepositoty(ApplicationDbContext contex) : base(contex)
        {

        }
    }
}

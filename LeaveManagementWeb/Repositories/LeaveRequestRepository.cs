using AutoMapper;
using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;
using Microsoft.AspNetCore.Identity;

namespace LeaveManagementWeb.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly ApplicationDbContext _contex;
        private readonly IMapper _mapper;
        private readonly UserManager<Employee> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LeaveRequestRepository(ApplicationDbContext contex, IMapper mapper,
            UserManager<Employee> userManager, IHttpContextAccessor httpContextAccessor) : base(contex)
        {
            _contex = contex;
            _mapper = mapper;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task CreateLeaveRequest(LeaveRequestCreateVM model)
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor?.HttpContext?.User);
            var leaveRequest = _mapper.Map<LeaveRequest>(model);
            leaveRequest.DateRequasted = DateTime.Now;
            leaveRequest.RequestingEmployeeId = user.Id;

            await AddAsync(leaveRequest);
        }
    }
}

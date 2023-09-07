using AutoMapper;
using AutoMapper.QueryableExtensions;
using LeaveManagementWeb.Constant;
using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementWeb.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _contex;
        private readonly UserManager<Employee> _userManager;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        private readonly AutoMapper.IConfigurationProvider _configurationProvider;
        private readonly IEmailSender _emailSender;

        public LeaveAllocationRepository(ApplicationDbContext contex, 
            UserManager<Employee> userManager,
            ILeaveTypeRepository leaveTypeRepository,
            IMapper mapper,
            AutoMapper.IConfigurationProvider configurationProvider,
            IEmailSender emailSender) : base(contex)
        {
            _contex = contex;
            _userManager = userManager;
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
            _configurationProvider = configurationProvider;
            _emailSender = emailSender;
        }

        public Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            return _contex.LeaveAllocations.AnyAsync(q => employeeId == q.EmployeeId 
                                                        && leaveTypeId == q.LeaveTypeId 
                                                        && period == q.Period);
        }
         
        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
        {
            var allocations = await _contex.LeaveAllocations
                .Include(q => q.LeaveType)
                .Where(q => q.EmployeeId == employeeId)
                //.ProjectTo<LeaveAllocationVM>(_configurationProvider)
                .ToListAsync();

            var employee = await _userManager.FindByIdAsync(employeeId);

            var employeeAllocationModel = _mapper.Map<EmployeeAllocationVM>(employee);

            employeeAllocationModel.LeaveAllocations = _mapper.Map<List<LeaveAllocationVM>>(allocations);

            return employeeAllocationModel;
        }

        public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id)
        {
            var allocation = await _contex.LeaveAllocations
                .Include(q => q.LeaveType)
                .ProjectTo<LeaveAllocationEditVM>(_configurationProvider)
                .FirstOrDefaultAsync(q => q.Id == id);

            if (allocation == null)
                return null;

            var employee = await _userManager.FindByIdAsync(allocation.EmployeeId);

            var model = _mapper.Map<LeaveAllocationEditVM>(allocation);

            model.Employee = _mapper.Map<EmployeeListVM>(await _userManager.FindByIdAsync(allocation.EmployeeId));

            return model;
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await _userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await _leaveTypeRepository.GetAsync(leaveTypeId);
            var allocations = new List<LeaveAllocation>();
            var checkedEmployees = new List<Employee>();

            foreach (var employee in employees)
            {
                if (await AllocationExists(employee.Id, leaveTypeId, period))
                    continue;

                allocations.Add(new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays
                });
                checkedEmployees.Add(employee);
            }
            await AddRangeAsync(allocations);

            foreach(var employee in checkedEmployees)
            {
                await _emailSender.SendEmailAsync(employee.Email, $"Leave Allocation Posted for {period}", 
                    $"{leaveType.Name} leave has been poste for the period {period}");
            }
        }

        public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model)
        {
            var leaveAllocation = await GetAsync(model.Id);

            if (leaveAllocation == null)
                return false;

            leaveAllocation.Period = model.Period;
            leaveAllocation.NumberOfDays = model.NumberOfDays;
            await UpdateAsync(leaveAllocation);
            return true;
        }

        public async Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId)
        {
            return await _contex.LeaveAllocations.FirstOrDefaultAsync(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId);
        }
    }
}

﻿using LeaveManagement.Data;
using LeaveManagement.Common.Models;

namespace LeaveManagement.App.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int LeaveTypeId);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id);
        Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId);
        Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);
    }
}

﻿using AutoMapper.Configuration.Conventions;
using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;

namespace LeaveManagementWeb.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();
        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);
        Task<List<LeaveRequest>> GetAllAsync(string employeeId);
        Task ChangeApprovalStatus(int leaveRequestId, bool approved);
        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();
        Task CancelLeaveRequest(int leaveRequestId);
    }
}

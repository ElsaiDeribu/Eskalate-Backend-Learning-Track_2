﻿using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Domain;
using HR.LeaveManagement.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveManagement.Persistence.Repositories
{
     public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly LeaveManagementDbContext _dbContext;

        public LeaveTypeRepository(LeaveManagementDbContext dbContext) : base(dbContext) 
        {
            _dbContext = dbContext;
        }
    }
}

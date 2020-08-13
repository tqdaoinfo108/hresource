﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using hrapi.Model;

namespace hrapi.Repository
{
    public interface IStaffRepository
    {
        object Claims { get; }

        Task<int> Create(Staffs staffs);
        Task<List<Staffs>> GetAll();
        Task<Staffs> GetById(int id);
        Task<Staffs> GetByStaffCode(string staffCode);
        Task<string> GenerateToken(string staffCode,string token);
        Task<string> Update(string staffCode, Staffs staffs);
        Task<string> Delete(int id);
    }
}

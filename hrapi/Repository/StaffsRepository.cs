using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hrapi.Database;
using hrapi.Model;
using Microsoft.EntityFrameworkCore;

namespace hrapi.Repository
{
    public class StaffsRepository : IStaffRepository
    {
        private IApplicationDbContext _dbcontext;

        public StaffsRepository(IApplicationDbContext dbcontext)
        {
            this._dbcontext = dbcontext;
        }

        public object Claims => throw new NotImplementedException();

        public async Task<int> Create(Staffs staffs)
        {
            _dbcontext.staffs.Add(staffs);
            await _dbcontext.SaveChanges();
            return staffs.StaffID;
        }
        
        public async Task<string> Delete(int id)
        {
            var employeedel = _dbcontext.staffs.Where(x => x.StaffID == id).FirstOrDefault();
            if (employeedel == null) return "Staff does not exists";
            _dbcontext.staffs.Remove(employeedel);
            await _dbcontext.SaveChanges();
            return "Staff details deleted modified";
        }

        public async Task<string> GenerateToken(string staffCode,string token)
        {
            var staff = await _dbcontext.staffs.Where(x => x.StaffCode.Equals(staffCode)).FirstOrDefaultAsync();
            if (staff == null) return "Staff does not exists";
            // change model
            staff.Token = token;
            staff.LastLogin = DateTime.Now;
            await _dbcontext.SaveChanges();
            return "Staff details successfully modified";
        }

        public async Task<List<Staffs>> GetAll()
        {
            var staffs = await _dbcontext.staffs.ToListAsync<Staffs>();
            return staffs;
        }

        public async Task<Staffs> GetById(int id)
        {
            var staff = await _dbcontext.staffs.Where(x => x.StaffID == id).FirstOrDefaultAsync();
            return staff;
        }

        public async Task<Staffs> GetByStaffCode(string staffCode)
        {
            var staff = await _dbcontext.staffs.Where(x => x.StaffCode.Equals(staffCode)).FirstOrDefaultAsync();
            return staff;
        }

        public async Task<int> Update(string staffCode, Staffs staffs)
        {
            var modelUpdate = await _dbcontext.staffs.Where(x => x.StaffCode.Equals(staffCode)).FirstOrDefaultAsync();
            if (modelUpdate == null) return 0;
            // change model
            modelUpdate.LastLogin = DateTime.Now;
            
            await _dbcontext.SaveChanges();
            return modelUpdate.StaffID;
        }

    }
}

using Comoon.DTOs;
using Microsoft.EntityFrameworkCore;
using Repositories.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IContext _context;

        public UserRepository(IContext context)
        {
            _context = context;
        }
      

        public async Task<User> AddAsync(string UserName, string UserFamilyName, string UserId, DateTime UserBirthday, string HMO, string  Gender, List<Child> ChildrenOfParent)
        {
            var c = _context.Users.Add(new User() { UserName = UserName, UserFamilyName = UserFamilyName, UserId = UserId, UserBirthday = UserBirthday, HMO = HMO, Gender = Gender ,ChildrenOfParent= ChildrenOfParent });
            await _context.SaveChangesAsync();
            return c.Entity;
        }

        public async  Task DeleteAsync(string UserId)
        {
            _context.Users.Remove(await GetByIdAsync(UserId));
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(string UserId)
        {
            throw new NotImplementedException();
        }

      
       

        public async Task<User> UpdateAsync(User User)
        {
            User u1 = await GetByIdAsync(User.UserId);
            u1.UserId = User.UserId;
            u1.UserName = User.UserName;
            u1.UserFamilyName = User.UserFamilyName;
            u1.Gender = User.Gender;
            u1.UserBirthday = User.UserBirthday;
            await _context.SaveChangesAsync();
            return u1;
        }



      

   
        


    }
}

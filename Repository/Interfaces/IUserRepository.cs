using Comoon.DTOs;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();

        Task<User> GetByIdAsync(string  id);

        Task<User> AddAsync( string UserName,string  UserFamilyName,  string UserId, DateTime UserBirthday, string HMO, string Gender, List<Child> ChildrenOfParent );
        Task<User> UpdateAsync(User User);

        Task DeleteAsync(string UserId);
    }
}

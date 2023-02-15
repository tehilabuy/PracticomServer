using Comoon.DTOs;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAllAsync();

        Task<UserDTO> GetByIdAsync(string  id);

        Task<UserDTO> AddAsync(string UserName, string UserFamilyName, string UserId, DateTime UserBirthday, string HMO, string  Gender, List<ChildDTO> ChildrenOfParent);

        Task<UserDTO> UpdateAsync(UserDTO User);

        Task DeleteAsync(string UserId);


    }
}

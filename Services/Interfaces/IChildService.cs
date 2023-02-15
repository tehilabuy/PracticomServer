using Comoon.DTOs;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IChildService
    {
        Task<List<ChildDTO>> GetAllAsync();

        Task<ChildDTO> GetByIdAsync(string ChildId);

        Task<ChildDTO> AddAsync(string ChildName, string ChildId, DateTime ChildBirthday);
        Task<ChildDTO> UpdateAsync(ChildDTO Child);

        Task DeleteAsync(string ChildId);
    }
}

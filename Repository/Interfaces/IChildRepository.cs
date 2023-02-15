using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IChildRepository
    {
        Task<List<Child >> GetAllAsync();

        Task<Child> GetByIdAsync(string ChildId);

        Task<Child> AddAsync(string ChildName,  string ChildId, DateTime ChildBirthday);
        Task<Child> UpdateAsync(Child Child);

        Task DeleteAsync(string ChildId);
    }
}

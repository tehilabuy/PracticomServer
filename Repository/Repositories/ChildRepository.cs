using Microsoft.EntityFrameworkCore;
using Repositories.Entities;
using Repositories.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

namespace Repositories.Repositories
{
     public class ChildRepository : IChildRepository
    {
        private readonly IContext _context;

        public ChildRepository(IContext context)
        {
            _context = context;
        }
        public async  Task<Child> AddAsync(string NameOfChild, string IdOfChild, DateTime BirthdayOfChild)
        {
            var r = _context.Children.Add(new Child() { NameOfChild = NameOfChild, IdOfChild = IdOfChild, BirthdayOfChild = BirthdayOfChild });
            await _context.SaveChangesAsync();
            return r.Entity;
        }

        public async Task DeleteAsync(string ChildId)
        {
            _context.Children.Remove(await GetByIdAsync(ChildId));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.ToListAsync();
        }

        public async Task<Child> GetByIdAsync(string  id)
        {
            return await _context.Children.FindAsync(id);
        }

        public async Task<Child> UpdateAsync(Child Child)
        {

            Child c1 = await GetByIdAsync(Child.IdOfChild);
            c1.NameOfChild = Child.NameOfChild;
            c1.BirthdayOfChild = Child.BirthdayOfChild;
            await _context.SaveChangesAsync();
            return c1;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Repositories.Entities;

namespace Repositories.Interfaces
{
    public  interface IContext
    {
        DbSet<User> Users { get; set; }

        DbSet<Child> Children { get; set; }
    

        Task<int> SaveChangesAsync(CancellationToken cancellation = default);
    }
}

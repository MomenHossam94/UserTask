using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UserTask.Domain.Entities;

namespace UserTask.Application.Common.Interfaces
{
    public interface IUserDbContext
    {
        DbSet<Domain.Entities.User> Users { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}

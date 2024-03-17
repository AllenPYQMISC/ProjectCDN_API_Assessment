using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectCDN_API.Models;

namespace ProjectCDN_API.Data
{
    public class UserModelsContext : DbContext
    {
        public UserModelsContext (DbContextOptions<UserModelsContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectCDN_API.Models.UserModel> UserModel { get; set; } = default!;
    }
}

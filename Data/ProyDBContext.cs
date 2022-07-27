using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleLogin.Data
{
    public class ProyDBContext : IdentityDbContext
    {
        public ProyDBContext(DbContextOptions<ProyDBContext> options)
            : base(options)
        {
        }
        //dotnet tool install --global dotnet-ef
        //dotnet ef migrations add InitialCreate
        //dotnet ef database update
    }
}

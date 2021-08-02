using Domaine.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.context
{
    public class ClientContext:DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Article> Articles { get; set; }
    }
}

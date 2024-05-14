using MvcCore2AWSPostgresEC2.Models;
using Microsoft.EntityFrameworkCore;


namespace MvcCore2AWSPostgresEC2.Data
{
    public class DepartamentosContext: DbContext
    {
        public DepartamentosContext(DbContextOptions<DepartamentosContext> options) : base(options) { }
        public DbSet<Departamento> Departamentos { get; set; }
    }
}

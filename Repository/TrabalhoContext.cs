using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Trabalho.Models;

namespace Trabalho.Repository
{
    public class TrabalhoContext : DbContext
    {
        //DBContext, cria as queries 
        //DBSet faz a gerencia dos dados, Insert/Update/Delete/Put, pra cada modelo precisa de um
        public DbSet<CaseModeModel> CaseMode { get; set; }
        public TrabalhoContext(DbContextOptions<TrabalhoContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ILoggerFactory factory = LoggerFactory.Create(l => l.AddConsole());
            optionsBuilder.UseLoggerFactory(factory);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Metodo responsavel por mapear o modelo no banco com os parametros criados no PieMapping
            modelBuilder.ApplyConfiguration(new CaseModeMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
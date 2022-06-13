using Microsoft.EntityFrameworkCore;
using ProjetoConexaoEFCore.Models;

namespace ProjetoConexaoEFCore.Data
{
    public class ProjetoConexaoContext : DbContext
    {
        public ProjetoConexaoContext(DbContextOptions<ProjetoConexaoContext> options) : base(options)   
        {

        }


        public DbSet<Imovel> Imoveis { get; set; }
    }
}

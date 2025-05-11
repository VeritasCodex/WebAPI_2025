using Microsoft.EntityFrameworkCore;
using ShoppingAPI_2025.DAL.Entities;

namespace ShoppingAPI_2025.DAL
{
    public class DataBaseContext : DbContext
    {
        //Así me conecto a la BD por medio de este constructor
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        //Este metodo que es propio de EF CORE me sirve para configurar unos indices de cada campo de una tabla en BD
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();// Aqui creo un indice del campo Name para la tabla Countries
        }

        #region DbSets
        public DbSet<Country> Countries { get; set; }
        #endregion
    }
}

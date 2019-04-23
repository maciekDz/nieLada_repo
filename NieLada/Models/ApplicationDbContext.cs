using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NieLada.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace NieLada.Models
{
    public interface IApplicationDbContext
    {
        IDbSet<KontoUzytkownika> KontaUzytkownikow { get; set; }
        IDbSet<Zamowienie> Zamowienia { get; set; }
        IDbSet<Styl> Style { get; set; }
        IDbSet<Wielkosc> Wielkosci { get; set; }
        IDbSet<Gestosc> Gestosci { get; set; }
        int SaveChanges();
        void Dispose();
        Task SaveChangesAsync();
        object Entry(Zamowienie zamowienie);
    }

   public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
   
    {

        public ApplicationDbContext(): base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer<ApplicationDbContext>(new CreateDatabaseIfNotExists<ApplicationDbContext>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        Task IApplicationDbContext.SaveChangesAsync()
        {
            throw new NotImplementedException();
        }


        public object Entry(Zamowienie zamowienie)
        {
            throw new NotImplementedException();
        }

        //public new DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        public IDbSet<KontoUzytkownika> KontaUzytkownikow { get; set; }
        public IDbSet<Zamowienie> Zamowienia { get; set; }
        public IDbSet<Styl> Style { get; set; }
        public IDbSet<Wielkosc> Wielkosci { get; set; }
        public IDbSet<Gestosc> Gestosci { get; set; }
        public object ObjectStateManager { get; internal set; }

        //public System.Data.Entity.DbSet<NieLada.Models.Zamowienie> Zamowienies { get; set; }
    }

   
}
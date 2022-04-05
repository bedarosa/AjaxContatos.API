using AjaxContatos.Data.Mappings;
using AjaxContatos.Domain.EntitiesBase;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AjaxContatos.Data.Context
{
    public class AjaxContatosContext : DbContext
    {
        public AjaxContatosContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new ContatoMapping());

            modelBuilder.Properties<string>()
                .Configure(x => x.HasColumnType("varchar")
                .HasMaxLength(100));
                

            base.OnModelCreating(modelBuilder);
        }

    }
}

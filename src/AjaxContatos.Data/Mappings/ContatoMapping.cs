using AjaxContatos.Domain.EntitiesBase;
using System.Data.Entity.ModelConfiguration;

namespace AjaxContatos.Data.Mappings
{
    public class ContatoMapping : EntityTypeConfiguration<Contato>
    {
        public ContatoMapping()
        {
            HasKey(x => x.Id);

            Property(x => x.Nome)
                .IsRequired();

            Property(x => x.Telefone)
                .IsRequired();

            Property(x => x.Email)
                .IsRequired();

            Property(x => x.Cpf)
                .IsRequired();

            ToTable("Contatos");
        }
    }
}

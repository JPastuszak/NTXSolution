

using System.Data.Entity.ModelConfiguration;
using NTXSolution.Domain.Entities;

namespace NTXSolution.Infra.Data.EntityConfig
{
    public class EditoraConfiguration : EntityTypeConfiguration<Editora>
    {
        public EditoraConfiguration()
        {
            HasKey(c => c.EditoraId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            

        }
    }
}

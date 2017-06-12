
using System.Data.Entity.ModelConfiguration;
using NTXSolution.Domain.Entities;

namespace NTXSolution.Infra.Data.EntityConfig
{
    public class LivroConfiguration : EntityTypeConfiguration<Livro>
    {
        public LivroConfiguration()
        {
            HasKey(p => p.LivroId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(250);

           

            HasRequired(p => p.Editora)
                .WithMany()
                .HasForeignKey(p => p.EditoraId);
        }
    }
}

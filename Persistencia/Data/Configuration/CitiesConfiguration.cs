using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class CitiesConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("city");

        builder.HasIndex(e => e.IdstateFk, "IX_city_IdstateFk");

        builder.Property(e => e.Name)
            .HasMaxLength(50)
            .HasColumnName("name");

        builder.HasOne(d => d.IdstateFkNavigation).WithMany(p => p.Cities)
            .HasForeignKey(d => d.IdstateFk)
            .OnDelete(DeleteBehavior.ClientSetNull);

    }
}

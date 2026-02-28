using Microsoft.EntityFrameworkCore;

using Shared.Models;

namespace WebBackend.Data;

public partial class OneEasyStubContext : DbContext {
	public OneEasyStubContext(DbContextOptions<OneEasyStubContext> options)
		: base(options) {
	}

	public virtual DbSet<Cliente> Clienti { get; set; }

	public virtual DbSet<LineaOrdine> LineeOrdini { get; set; }

	public virtual DbSet<Ordine> Ordini { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder) {
		modelBuilder.Entity<Cliente>(entity => {
			entity.ToTable("Clienti");

			entity.Property(e => e.ID);
			entity.Property(e => e.Cap)
				.HasMaxLength(5)
				.IsUnicode(false);
			entity.Property(e => e.Citta)
				.HasMaxLength(64)
				.IsUnicode(false);
			entity.Property(e => e.Email)
				.HasMaxLength(128)
				.IsUnicode(false);
			entity.Property(e => e.Indirizzo)
				.HasMaxLength(128)
				.IsUnicode(false);
			entity.Property(e => e.Provincia)
				.HasMaxLength(2)
				.IsUnicode(false);
			entity.Property(e => e.RagioneSociale)
				.HasMaxLength(255)
				.IsUnicode(false);
			entity.Property(e => e.Telefono)
				.HasMaxLength(12)
				.IsUnicode(false);
		});

		modelBuilder.Entity<LineaOrdine>(entity => {
			entity.ToTable("LineeOrdine");

			entity.Property(e => e.ID);
			entity.Property(e => e.Prodotto).HasMaxLength(50);
			entity.Property(e => e.OrdineID).HasColumnName("OrdineID");

			entity.HasOne(d => d.Ordine).WithMany(p => p.Linee)
				.HasForeignKey(d => d.OrdineID)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_LineeOrdine_Ordini");
		});

		modelBuilder.Entity<Ordine>(entity => {
			entity.ToTable("Ordini");

			entity.Property(e => e.ID);
			entity.Property(e => e.ClienteID);
			entity.Property(e => e.Data).HasColumnType("datetime");

			entity.HasOne(d => d.Cliente).WithMany(p => p.Ordini)
				.HasForeignKey(d => d.ClienteID)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_Ordini_Clienti");
		});

		OnModelCreatingPartial(modelBuilder);
	}

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

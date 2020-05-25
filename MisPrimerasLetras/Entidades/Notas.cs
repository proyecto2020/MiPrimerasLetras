namespace Entidades
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Notas : DbContext
    {
        public Notas()
            : base("name=Notas")
        {
        }

        public virtual DbSet<nota> notas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<nota>()
                .Property(e => e.periodo)
                .IsUnicode(false);

            modelBuilder.Entity<nota>()
                .Property(e => e.usuario_creacion)
                .IsUnicode(false);

            modelBuilder.Entity<nota>()
                .Property(e => e.usuario_modificacion)
                .IsUnicode(false);
        }
    }
}

namespace Entidades
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Parametros : DbContext
    {
        public Parametros()
            : base("name=Parametros")
        {
        }

        public virtual DbSet<Parametro> parametros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parametro>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Parametro>()
                .Property(e => e.valor)
                .IsUnicode(false);

            modelBuilder.Entity<Parametro>()
                .Property(e => e.descripcion)
                .IsUnicode(false);
        }
    }
}

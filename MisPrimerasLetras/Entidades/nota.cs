namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nota")]
    public  class nota
    {
        [Key]
        public int id_nota { get; set; }

        public int fk_alumno { get; set; }

        public int fk_materia { get; set; }

        [Column("nota")]
        public double valor_nota { get; set; }

        [StringLength(100)]
        public string periodo { get; set; }

        [StringLength(100)]
        public string usuario_creacion { get; set; }

        [StringLength(100)]
        public string usuario_modificacion { get; set; }

        public DateTime? fecha_creacion { get; set; }

        public DateTime? fecha_modificacion { get; set; }
    }
}

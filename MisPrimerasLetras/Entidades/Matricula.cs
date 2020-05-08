namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Matricula")]
    public partial class Matricula
    {
        [Key]
        public int IdMatricula { get; set; }

        public DateTime fecha_matricula { get; set; }

        public int fk_alumno { get; set; }

        public int fk_grupo { get; set; }

        public int fk_pagos { get; set; }

        [StringLength(50)]
        public string usuario_creacion { get; set; }

        public DateTime fecha_creacion { get; set; }

        public DateTime ano_lectivo { get; set; }

        public Boolean estado { get; set; }

    }
}

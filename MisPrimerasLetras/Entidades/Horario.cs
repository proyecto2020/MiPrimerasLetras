namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("horario")]
    public partial class horario
    {
        [Key]
        public int id_horario { get; set; }

        public int fk_grupo { get; set; }

        //public int fk_salon { get; set; }

        public int fk_dia_hora { get; set; }

        public int fk_materia { get; set; }

        public DateTime fecha_creacion { get; set; }

        public DateTime fecha_modificaion { get; set; }

        [StringLength(100)]
        public string usuario_creacion { get; set; }

        [StringLength(100)]
        public string usuario_modificacion { get; set; }

        [StringLength(50)]
        public string dia { get; set; }

    }
}

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Parametros")]
    public partial class Parametro
    {
        public int id { get; set; }

        [StringLength(50)]
        public string nombre { get; set; }

        [StringLength(50)]
        public string valor { get; set; }

        [StringLength(50)]
        public string descripcion { get; set; }
    }
}

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gradoMateria")]
    public  class gradoMateria
    {
        // gradoMateria()
        //{

        //}
        public int id { get; set; }

   // public virtual ICollection<Course> Courses { get; set; }
        public virtual Materia  fk_materia { get; set; }

        public Grado fk_grado { get; set; }

        public int horas { get; set; }
    }


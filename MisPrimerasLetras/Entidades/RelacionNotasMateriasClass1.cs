using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class RelacionNotasMateriasClass : nota
    {
        public int id_Materia { get; set; }
        /// <summary>
        /// materia.
        /// </summary>
        public string  materia { get; set; }

     

    }
}

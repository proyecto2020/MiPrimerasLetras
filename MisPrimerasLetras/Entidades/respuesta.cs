using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Respuesta <T>
    {
        
        public int ResponseCode { get; set; }          
        
        public string ResponseMessage { get; set; }         
                 
        public string IdTransactionCode { get; set; }       

        public int RowsAffected { get; set; }

        public Collection<T> ResultData { get; set; }

    }
}

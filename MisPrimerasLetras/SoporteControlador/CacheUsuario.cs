using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SoporteControlador
{
    public static class CacheUsuario
    {

        public static int IdUsuario { get; set; }
        public static string NombreUsuario { get; set; }
        public static string ApellidoUsuario { get; set; }
        public static string Perfil { get; set; }
        public static string Correo { get; set; }
        public static string nombreParametro { get; set; }
        public static string periodo { get; set; }

        public static string[] data = new  string[4];

       public static DataTable dataTable = new DataTable();

        public static int grupo { get; set; }





        public static void Fill<T>(this T[] originalArray, T with)
            {
                for (int i = 0; i < originalArray.Length; i++)
                {
                    originalArray[i] = with;
                }
            }
        

    }
    }

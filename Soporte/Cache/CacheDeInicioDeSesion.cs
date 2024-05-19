using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte.Cache
{
    public static class CacheDeInicioDeSesion
    {
        public static int IdUser { get; set; }
        public static string NombreCompleto { get; set; }
        public static string Rol { get; set; }
        public static string Email { get; set; }
    }
}

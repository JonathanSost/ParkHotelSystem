using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal static class Parametros
    {
        public static string GetConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\moc\Documents\SantoSoninho.mdf;Integrated Security=True;Connect Timeout=30";
        }
    }
}

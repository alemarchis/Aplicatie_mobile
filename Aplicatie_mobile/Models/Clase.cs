using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicatie_mobile.Models
{
    public class Clase
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string NumeClasa { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Aplicatie_mobile.Models
{
    public class Reviews
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Parere { get; set; }
        public string Clasa { get; set; }
        public DateTime Date { get; set; }
    }
}

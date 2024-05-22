using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mobiilirakendus.Models
{
    public class Asjad
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Weight { get; set; }
    }

}

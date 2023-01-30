using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedonAppModelado.Models
{
    [Table("Frases")]
    public class Frase
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string TextoFrase { get; set; }
        public string Author { get; set; }
    }
}

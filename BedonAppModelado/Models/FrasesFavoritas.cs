using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BedonAppModelado.Models
{
    [Table("FrasesFavoritas")]
    public class FrasesFavoritas:Frase
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public int frasef { get; set; }
        public bool isFavorite { get; set; }
        
        public void toggleFavorite(Frase frase)
        {
            FrasesFavoritas ff = App.FrasesRepo.GetFraseFavorita(frase.Id);
            ff.isFavorite = !ff.isFavorite;
            App.FrasesRepo.UpdateFraseFavorita(ff);
        }
    }
}

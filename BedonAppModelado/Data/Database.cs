using BedonAppModelado.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedonAppModelado.Data
{
    public class Database
    {
        string _dbPath;
        private SQLiteConnection conn;

        public Database(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Frase>();
            conn.CreateTable<FrasesFavoritas>();
        }

        public int AddNewFrase(Frase frase)
        {
            Init();
            int result = conn.Insert(frase);
            return result;
        }

        public int DeleteFrase(Frase frase)
        {
            Init();
            int result = conn.Delete(frase);
            return result;
        }

        public List<Frase> GetAllFrases()
        {
            Init();
            List<Frase> frases = conn.Table<Frase>().ToList();
            return frases;
        }

        public Frase GetFrase(int Id)
        {
            Init();
            Frase frase = new Frase();
            List<Frase> frases = conn.Table<Frase>().ToList();
            foreach (Frase f in frases)
            {
                if (f.Id == Id)
                {
                    frase = f;
                    break;
                }
            }
            return frase;
        }

        public int UpdateFrase(Frase frase)
        {
            Init();
            int result = conn.Update(frase);
            return result;
        }

        public int AddNewFraseFavorita(FrasesFavoritas frase)
        {
            Init();
            int result = conn.Insert(frase);
            return result;
        }

        public int UpdateFraseFavorita(FrasesFavoritas frase)
        {
            Init();
            int result = conn.Update(frase);
            return result;
        }

        public List<FrasesFavoritas> GetFavorites()
        {
            Init();
            List<FrasesFavoritas> frases = conn.Table<FrasesFavoritas>().ToList();
            List<FrasesFavoritas> frasesF = new List<FrasesFavoritas>();
            foreach (FrasesFavoritas frase in frases)
            {
                if(frase.isFavorite == true)
                {
                    frasesF.Add(frase);
                }
            }    
            return frasesF;
        }

        public FrasesFavoritas GetFraseFavorita(int Id)
        {
            Init();
            FrasesFavoritas frase = new FrasesFavoritas();
            List<FrasesFavoritas> frases = conn.Table<FrasesFavoritas>().ToList();
            foreach (FrasesFavoritas f in frases)
            {
                if (f.frasef == Id)
                {
                    frase = f;
                    break;
                }
            }
            return frase;
        }
    }
}

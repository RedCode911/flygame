using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Database
{
    public class DatabaseConnection
    {
        private LiteDatabase _databasevs = new LiteDatabase("ScoreVs.db");
        private LiteDatabase _databasesolo = new LiteDatabase("ScoreSolo.db");

        public ILiteCollection<T> GetCollectionsolo<T>()
        {
            return _databasesolo.GetCollection<T>();
        }
        public ILiteCollection<T> GetCollectionsVs<T>()
        {
            return _databasevs.GetCollection<T>();
        }
    }
}

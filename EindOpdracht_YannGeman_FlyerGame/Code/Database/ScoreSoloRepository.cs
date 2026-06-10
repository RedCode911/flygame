using Code.GameCore.System.Score;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Database
{
    public class ScoreSoloRepository
    {
        private DatabaseConnection DatabaseConnection { get; }

        public ILiteCollection<ScoreKeeper> GetCollection()
        {
            return DatabaseConnection.GetCollectionsolo<ScoreKeeper>();
        }

        public ScoreSoloRepository(DatabaseConnection databaseConnection)
        {
            DatabaseConnection = databaseConnection;
        }

        public void Add(ScoreKeeper score)
        {
            GetCollection().Insert(score);
        }

        public List<ScoreKeeper> GetAll()
        {
            return GetCollection().FindAll()
                                  .ToList();
        }

    }
}

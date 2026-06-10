using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.GameCore.System.Score
{
    public class ScoreKeeper
    {
        
        public ScoreKeeper(int score)
        {
            this.score = score;
        }

        public int score { get; set; }

    }
}

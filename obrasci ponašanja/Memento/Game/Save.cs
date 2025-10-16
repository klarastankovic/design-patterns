using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Game
{
    public class Save
    {
        public DateTime Timestamp { get; private set; }
        public int Level { get; private set; }
        public int Score { get; private set; }
        public int Lives { get; private set; }
        public Save (int  level, int score, int lives)
        {
            this.Level = level;
            this.Score = score;
            this.Lives = lives;
        }
    }
}

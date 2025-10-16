using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Game
{
    public class Pacman : Game
    {
        int lives = 3;
        int score = 0;
        int level = 1;
        public void WinLevel() { level++; score += 100; }
        public void LoseLife() { lives--; }
        public bool IsGameOver() { return lives == 0; }
        public int HighScore() { return score; }
        public void LoadGame(Save save)
        {
            this.lives = save.Lives;
            this.score = save.Score;
            this.level = save.Level;
        }
        public Save SaveGame()
        {
            return new Save(this.level, this.score, this.lives);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Game
{
    public interface Game
    {
        Save SaveGame();
        void LoadGame(Save save);
        int HighScore();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Game
{
    public static class GameTester
    {
        public static void Test()
        {
            MemoryCard card = new MemoryCard();
            Pacman game = new Pacman();
            Console.WriteLine(game.HighScore());
            game.WinLevel();
            Console.WriteLine(game.HighScore());
            card.StoreSave(game.SaveGame());
            game.WinLevel();
            while (!game.IsGameOver())
            {
                game.LoseLife();
            }
            Console.WriteLine("Sorry, game over! Score: " + game.HighScore());
            Console.WriteLine("Loading...");
            game.LoadGame(card.GetLastSave());
            Console.WriteLine(game.HighScore());
        }
    }
}

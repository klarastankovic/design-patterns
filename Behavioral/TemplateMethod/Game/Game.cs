using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Game
{
    public abstract class Game
    {
        public void Play() //metoda predlozak
        {
            Start();
            while(HaveWinner == false)
            {
                TakeTurn();
            }
            Console.WriteLine("Player " + WinningPlayer + " wins!");
        }
        public abstract void Start();
        protected abstract void TakeTurn();
        protected abstract bool HaveWinner { get; }
        protected abstract int WinningPlayer { get; }
        protected int currentPlayer;
        protected readonly int numberOfPlayers;
        public Game(int numberOfPlayers)
        {
            this.numberOfPlayers = numberOfPlayers;
        }
    }
}

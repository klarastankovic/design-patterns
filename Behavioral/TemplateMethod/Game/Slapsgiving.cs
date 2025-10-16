using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Game
{
    public class Slapsgiving : Game
    {
        Random generator;
        int currentTurn;
        List<int> playerHP;
        public Slapsgiving(int playerCount) : base(playerCount)
        {
            this.generator = new Random();
            this.playerHP = Enumerable.Repeat(10, playerCount).ToList();
        }
        protected override bool HaveWinner { get { return this.playerHP.Min() <= 0; } }
        protected override int WinningPlayer { get { return this.playerHP.IndexOf(this.playerHP.Max()); } }
        public override void Start()
        {
            Console.WriteLine("Welcome to the slapsgiving match!");
        }
        protected override void TakeTurn()
        {
            this.currentPlayer = (currentPlayer + 1) % numberOfPlayers;
            Console.WriteLine("Turn " + currentTurn + ", player: " + currentPlayer);
            this.CountSlapsNext();
            this.currentTurn++;
        }
        private void CountSlapsNext()
        {
            int slappingPower = generator.Next(0, 4);
            int slappedPlayerIndex = (this.currentPlayer + 1) % numberOfPlayers;
            this.playerHP[slappedPlayerIndex] -= slappingPower;
            Console.WriteLine("slapped player " + slappedPlayerIndex + " to HP " + this.playerHP[slappedPlayerIndex]);
        }
    }
}

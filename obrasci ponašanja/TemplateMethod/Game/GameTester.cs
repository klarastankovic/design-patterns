using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Game
{
    public static class GameTester
    {
        public static void Test()
        {
            Game game = new Slapsgiving(2);
            game.Play();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorClickerGame
{
    internal class BigUpgrade : ICommand
    {
        ClickerGame Game;
        public char Character { get; } = 's';

        public BigUpgrade(ClickerGame game)
        {
            Game = game;
        }
        public void Run()
        {
            Game.BuyBigUpgrade();
        }
    }
}

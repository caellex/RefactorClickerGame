using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorClickerGame
{
    internal class SmallUpgrade : ICommand
    {
        ClickerGame Game;
        public char Character { get; } = 'k';
        public SmallUpgrade(ClickerGame game)
        {
            Game = game;
        }

        public void Run()
        {
            Game.BuySmallUpgrade();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorClickerGame
{
    internal class ClickPoints : ICommand
    {
        private ClickerGame Game;
        public char Character { get; } = ' ';
        public ClickPoints(ClickerGame game)
        {
            Game = game;
        }
        public void Run()
        {
            Game.Click();
        }
    }
}

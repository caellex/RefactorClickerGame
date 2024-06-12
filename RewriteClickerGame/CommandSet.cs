using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorClickerGame
{
    internal class CommandSet
    {
        private ICommand[] _commands;
        public CommandSet(ClickerGame game)
        {
            _commands =
            [
            new ClickPoints(game),
            new SmallUpgrade(game),
            new BigUpgrade(game),
            new ExitGame(),
            ];

        }



    public void RunCommand(char input)
    {
            var MatchedCommand = _commands.Where(command => input == command.Character);
            foreach (var command in MatchedCommand)
            {
                if (input == command.Character)
                {
                    command.Run();
                }
            }

    }



    }

}

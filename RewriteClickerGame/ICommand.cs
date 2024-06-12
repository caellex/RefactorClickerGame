using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorClickerGame
{
    public interface ICommand
    {
        void Run();
        public char Character { get;}
    }
}

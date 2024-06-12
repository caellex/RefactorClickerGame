using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorClickerGame
{
    internal class ClickerGame
    {
        public int points = 0;
        public int pointsPerClick = 1;
        public int pointsPerClickIncrease = 1;

        

        public int GetPoints()
        {
            return points;
        }

        public void Click()
        {
            points += pointsPerClick;
        }

        public void BuySmallUpgrade()
        {
            if (points >= 10)
            {
                points -= 10;
                pointsPerClick += pointsPerClickIncrease;
            }
        }

        public void BuyBigUpgrade()
        {
            if (points >= 100)
            {
                points -= 100;
                pointsPerClickIncrease++;
            }
        }

    }
}

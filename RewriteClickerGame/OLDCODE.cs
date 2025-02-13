﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace RefactorClickerGame
{
    internal class OLDCODE
    {
        public void Main()
        {
            int points = 0;
            int pointsPerClick = 1;
            int pointsPerClickIncrease = 1;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Kommandoer:\r\n" +
                "- SPACE = klikk(og få poeng)\r\n" +
               "- K = kjøp oppgradering \r\nøker poeng per klikk koster 10 poeng\r\n" +
               "- S = kjøp superoppgradering øker \"poeng per klikk\" for den vanlige oppgraderingen. koster 100 poeng\r\n " +
               "- X = avslutt applikasjonen");
    
                Console.WriteLine($"Du har {points} poeng.");
                Console.WriteLine("Trykk tast for ønsket kommando.");
                var command = Console.ReadKey().KeyChar;
                if (command == 'x') Environment.Exit(0);
                else if (command == ' ') points += pointsPerClick;
                else if (command == 'k' && points >= 10)
                {
                    points -= 10;
                    pointsPerClick += pointsPerClickIncrease;
                }
                else if (command == 's' && points >= 100)
                {
                    points -= 100;
                    pointsPerClickIncrease++;
                }
            }
        }
    }
}

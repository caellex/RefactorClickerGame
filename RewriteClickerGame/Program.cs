using System.Runtime.ConstrainedExecution;

namespace RefactorClickerGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClickerGame game = new ClickerGame();
            CommandSet cmd = new CommandSet(game);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Kommandoer:\r\n" + 
                "- SPACE = klikk(og få poeng)\r\n" +
               "- K = kjøp oppgradering \r\nøker poeng per klikk koster 10 poeng\r\n" +
               "- S = kjøp superoppgradering øker \"poeng per klikk\" for den vanlige oppgraderingen. koster 100 poeng\r\n " +
               "- X = avslutt applikasjonen");
    
                Console.WriteLine($"Du har {game.GetPoints()} poeng.");
                Console.WriteLine("Trykk tast for ønsket kommando.");

                char command = Console.ReadKey(true).KeyChar;
                cmd.RunCommand(command);


            }

        }
    }
}


//Skriv om til mer objektorientert ved å innføre en klasse ClickerGame med objektvariabler for de tre int-variablene og en metode for hver kommando.
//Innfør også et interface ICommand med kun én metode, Run. Lag så en klasse for hver kommando i applikasjonen.
//Lag også en egen klasse CommandSet. Denne har en array med et objekt av hver kommando.
//Når brukeren taster et tegn, skal dette sendes til metoden RunCommand i CommandSet.
//Der slår den opp hvilken kommando som har den aktuelle bokstaven og kjører så Run på denne kommandoen.
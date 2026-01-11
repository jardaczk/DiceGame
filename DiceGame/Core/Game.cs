using kostka.Utils;

public class Game
{
    OutputWriter outputWriter = new OutputWriter();
    InputReader inputReader = new InputReader();
    DiceLogo diceLogo = new DiceLogo();
    Dice dice = new Dice(6);
    PowerUps powerUps = new PowerUps();

    private int celekHrace = 0;
    private int celekPc = 0;
    private int actualround = 0;
    private int pcwins = 0;
    private int yourwins = 0;
    private int hodHrace3 = 0;
    public void play()
    {
        while (true)
        {
            actualround++;
            outputWriter.WriteLine("\n\nPress enter to roll dice", ConsoleColor.Green); //loop aby neskoncil
            string LetsBeguin = inputReader.ReadString();
            Console.Clear();
            powerUps.SpawnRate();
            powerUps.HasDoubleDice();
            if (powerUps.diceDoubler == true)
            {
                outputWriter.WriteLine("You got DoubleDice PowerUp!, rolling 2x 6 and 1x 10", ConsoleColor.Red);
            }
            int HodHrace = dice.Hod();
            outputWriter.WriteLine("You rolled " + HodHrace + " . . .", ConsoleColor.Magenta);
            diceLogo.Logo(HodHrace);
            int HodPc = dice.Hod();
            outputWriter.WriteLine("Computer rolled " + HodPc + " . . .", ConsoleColor.Red);
            diceLogo.Logo(HodPc);
            celekHrace = celekHrace + HodHrace;
            celekPc = celekPc + HodPc;
            int HodHrace2 = dice.Hod();
            outputWriter.WriteLine("You rolled " + HodHrace2 + " . . .", ConsoleColor.Magenta);
            diceLogo.Logo(HodHrace2);
            int HodPc2 = dice.Hod();
            outputWriter.WriteLine("Computer rolled " + HodPc2 + " . . .", ConsoleColor.Red);
            diceLogo.Logo(HodPc2);

            if (powerUps.diceDoubler == true) //pokud je power up double dice
            {
                hodHrace3 = dice.Hod();
                outputWriter.WriteLine("You rolled (PowerUp) " + hodHrace3 + " . . .", ConsoleColor.Magenta);
                diceLogo.Logo(hodHrace3);
            }
            outputWriter.Write("Score now YOU: " + HodHrace + " + " + HodHrace2 + " + " + hodHrace3 + " = ");
            outputWriter.WriteLine((HodHrace + HodHrace2 + hodHrace3).ToString());
            outputWriter.Write("          PC: " + HodPc + " + " + HodPc2 + " = ");
            outputWriter.WriteLine((HodPc + HodPc2).ToString());
            
            if (HodHrace + HodHrace2 + hodHrace3 > HodPc + HodPc2)
            {
                yourwins++;
            }
            else
            {
                pcwins++;
            }
            outputWriter.WriteLine($"YOUR WINS: {yourwins} PC WINS: {pcwins} ROUND: {actualround}", ConsoleColor.Red);

            if (actualround == 3)
            {
                if (yourwins > pcwins)
                {
                    outputWriter.WriteLine("Well you won!");
                    outputWriter.WriteLine($"Final score was: YOU: {yourwins} PC: {pcwins} - thanks for plaing");
                    break;
                }
                else
                {
                    outputWriter.WriteLine("Its look like you lost!");
                    outputWriter.WriteLine($"Final score was: YOU: {yourwins} PC: {pcwins} - thanks for plaing");
                    break;
                }

            }
            else
            {
                continue;
            }




        }
    }
}
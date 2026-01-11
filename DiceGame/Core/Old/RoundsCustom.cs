class RoundsCustom
{
    OutputWriter outputWriter = new OutputWriter();
    DiceLogo diceLogo = new DiceLogo();
    Dice dice = new Dice(6);

    private int CelekHrace = 0;
    private int CelekPc = 0;
    private int pcwins = 0;
    private int yourwins = 0;
    private int actualround = 0;
    private int maxRounds = 3;
    public void play(int maxRounds = 3)

    {
        if (maxRounds < 3)
        {
            maxRounds = 3;
            outputWriter.WriteWarning("Minimum rounds set is 3 (settings to 3)");
        }

        while (true)
        {
            actualround++;
            outputWriter.WriteLine("\n\nPress enter to roll dice", ConsoleColor.Green); //loop aby neskoncil
            string LetsBeguin = Console.ReadLine();
            Console.Clear();
            int HodHrace = dice.Hod();
            outputWriter.WriteLine("You rolled " + HodHrace + " . . .", ConsoleColor.Magenta);
            diceLogo.Logo(HodHrace);
            int HodPc = dice.Hod();
            outputWriter.WriteLine("Computer rolled " + HodPc + " . . .", ConsoleColor.Red);
            diceLogo.Logo(HodPc);
            CelekHrace = CelekHrace + HodHrace;
            CelekPc = CelekPc + HodPc;
            int HodHrace2 = dice.Hod();
            outputWriter.WriteLine("You rolled " + HodHrace2 + " . . .", ConsoleColor.Magenta);
            diceLogo.Logo(HodHrace2);
            int HodPc2 = dice.Hod();
            outputWriter.WriteLine("Computer rolled " + HodPc2 + " . . .", ConsoleColor.Red);
            diceLogo.Logo(HodPc2);
            outputWriter.Write("Score now YOU: " + HodHrace + " + " + HodHrace2 + " = ");
            outputWriter.WriteLine((HodHrace + HodHrace2).ToString());
            outputWriter.Write("          PC: " + HodPc + " + " + HodPc2 + " = ");
            outputWriter.WriteLine((HodPc + HodPc2).ToString());

            if (HodHrace + HodHrace2 > HodPc + HodPc2)
            {
                yourwins++;
            }
            else
            {
                pcwins++;
            }
            outputWriter.WriteLine($"YOUR WINS: {yourwins} PC WINS: {pcwins} ROUND: {actualround}", ConsoleColor.Red);

            if (actualround == maxRounds)
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
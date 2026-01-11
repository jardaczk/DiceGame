public class Dice
{
    private int _pocetStran;    // pocet stran kostky, nastavi se pres kontruktor pri zalozeni noveho objektu
    private readonly Random _random;

    /// <summary>
    /// Vytvoří novou instanci kostky s daným počtem stran.
    /// Pokud je zadán počet stran menší než 2, nastaví se výchozí hodnota 6.
    /// </summary>
    /// <param name="pocetStran">Počet stran kostky.</param>
    public Dice(int pocetStran)   // konstruktor
    {
        _pocetStran = pocetStran;
        ZkontrolujMinimalniPocetStran();        
        _random = new Random();
    }
    
    /// <summary>
    /// Provede náhodný hod kostkou a vrátí číslo v rozsahu 1 až počet stran.
    /// </summary>
    /// <returns>Výsledek hodu kostkou.</returns>
    public int Hod()
    {        
        int number = _random.Next(1, _pocetStran + 1);
        return number;
    }

    /// <summary>
    /// Provede náhodný hod kostkou s možností zadání bonusu nebo postihu.
    /// Výsledek je oříznut do platného rozsahu 1 až počet stran.
    /// </summary>
    /// <param name="bonus">Bonus (kladné číslo zvýhodňuje, záporné znevýhodňuje, 0 je férový hod).</param>
    /// <returns>Výsledek upraveného hodu kostkou.</returns>
    public int HodBuff(int bonus = 0) //bonus 0= hod ferove, +1 nadrzujeme, -1 handicap
    {
        int hodBonus = Hod() + bonus;
        return Math.Clamp( hodBonus, 1, _pocetStran);    // orizne na povoleny rozsah kostky
    }

    /// <summary>
    /// Ověří, že počet stran kostky je alespoň 2. Pokud není, nastaví výchozí hodnotu 6 a vypíše varování.
    /// </summary>
    private void ZkontrolujMinimalniPocetStran()
    {
        if (_pocetStran < 2)
        {
            _pocetStran = 6;
            Console.WriteLine("Pozor, musi byt v Dice nastaveno min 2 strany kostky");
            //ArgumentException ex = new ArgumentException("Počet stran musí být alespoň 2. Nastavuji na výchozí hodnotu 6.");
            // throw ex;
        }
    }

}



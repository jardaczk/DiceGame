
    class DiceLogo
    {
        /// <summary>
        /// Nastavit cislo aby se vypsalo logo kostky (není potřeba = 0)
        /// </summary>
        /// <param name="cislo"></param>
        /// Nastavit cislo od 1-10 vice ASCI obrazu není
        /// <returns></returns>
        public int Logo(int cislo)
        {
            switch (cislo)
            {
                case 0:
                    {
                        return cislo;
                    }
                case 1:
                    Console.WriteLine(
                    "┌─────┐\n" +
                    "│     │\n" +
                    "│  •  │\n" +
                    "│     │\n" +
                    "└─────┘");
                    return cislo;

                case 2:
                    Console.WriteLine(
                    "┌─────┐\n" +
                    "│ •   │\n" +
                    "│     │\n" +
                    "│   • │\n" +
                    "└─────┘");
                    return cislo;

                case 3:
                    Console.WriteLine(
                    "┌─────┐\n" +
                    "│ •   │\n" +
                    "│  •  │\n" +
                    "│   • │\n" +
                    "└─────┘");
                    return cislo;

                case 4:
                    Console.WriteLine(
                    "┌─────┐\n" +
                    "│ • • │\n" +
                    "│     │\n" +
                    "│ • • │\n" +
                    "└─────┘");
                    return cislo;

                case 5:
                    Console.WriteLine(
                    "┌─────┐\n" +
                    "│ • • │\n" +
                    "│  •  │\n" +
                    "│ • • │\n" +
                    "└─────┘");
                    return cislo;

                case 6:
                    Console.WriteLine(
                    "┌─────┐\n" +
                    "│ • • │\n" +
                    "│ • • │\n" +
                    "│ • • │\n" +
                    "└─────┘");
                    return cislo;

                case 7:
                    Console.WriteLine(
                    "┌─────┐\n" +
                    "│     │\n" +
                    "│  7  │\n" +
                    "│     │\n" +
                    "└─────┘");
                    return cislo;

                case 8:
                    Console.WriteLine(
                    "┌─────┐\n" +
                    "│     │\n" +
                    "│  8  │\n" +
                    "│     │\n" +
                    "└─────┘");
                    return cislo;

                case 9:
                    Console.WriteLine(
                    "┌─────┐\n" +
                    "│     │\n" +
                    "│  9  │\n" +
                    "│     │\n" +
                    "└─────┘");
                    return cislo;

                case 10:
                    Console.WriteLine(
                    "┌─────┐\n" +
                    "│     │\n" +
                    "│ 10  │\n" +
                    "│     │\n" +
                    "└─────┘");
                    return cislo;

                default:
                    Console.WriteLine("We dont have dice for this number, just imagen it . . .");
                    return cislo;
                    

                    
            }

        }
    }



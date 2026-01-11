using System.Diagnostics.Contracts;

class PowerUps
{
    private int WhatPowerUp = 0;
    public bool diceDoubler = false;
    Random random = new Random();
    
    /// <summary>
    /// Sance 10% na spawn power upu
    /// </summary>
    public void SpawnRate()
    { 
        int SpawnRate = random.Next(1, 101); 
        
        if (SpawnRate <= 100)  // ← 10% šance
        {
            WhatPowerUp = random.Next(1, 1);  
            
            if (WhatPowerUp == 1)
            {
                diceDoubler = true;
            }
        }
    }
 
    public bool HasDoubleDice()  
    {
        return diceDoubler;  
    }
    
    // Spotřebuj power-up
    public void UseDoubleDice()
    {
        diceDoubler = false; 
    }
}
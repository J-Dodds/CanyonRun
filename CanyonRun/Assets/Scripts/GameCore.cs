using UnityEngine;

public class GameCore
{

    public int Level{ get; set; }                                               // Player level
    public int XP { get; set; }                                                 // Total XP
    public bool BoostActive { get; set; }                                       // Shows if experience boost is active
    public float BoostTimeRemaining { get; set; }                               // Shows time remaining for boost
    public bool FireOnCooldown { get; set; }                                    // Shows if weapons are on cooldown
    public float FireCooldownRemaining { get; set; }                            // Shows time remaing until weapon can fire again
    public bool CanFire { get; set; }                                           // Shows if weapons can currently be fired

    public float Lerp(float minV, float maxV, float progress)                   // From value (MinV), To value (MaxV) and percentage Difference value (Progress)
    {
        return progress * (maxV - minV) + minV;                                 // Progress (0-1) x (Maximum value - Minimum value), where 1 = 100%
    }

    public int XPRequiredToNextLevel(int playerLevel)                                  //XP to next level                  
    {
        if (playerLevel % 2 ==0)
        {
            return playerLevel * 11;                                            //Even levels
        }
        else
        {
            return playerLevel * 10;                                            //Odd levels
        }
    }

    public int XPLossFromMine ( int playerLevel )
    {
        return playerLevel / 2;                                                 //At level 1 lose 2 xp, at 5 lose 10
    }

    public int XPGainFromMine ( int playerLevel )
    {
        return playerLevel * 3;                                                 //At level 1 gain 3 xp, at 5 gain 15
    }

    public int XPGainFromPickup ( int playerLevel )
    {
        return playerLevel * 4;                                                 //At level 1 gain 4 xp, at 5 gain 20
    }

    public void OnFire()
    {
        if(CanFire == true && FireOnCooldown == false)
        {
        CanFire = false;
        FireOnCooldown = true;
        FireCooldownRemaining = 0.75f;
        }
    }

    public void DecreaseFireCooldownRemaining(float timeElapsed)
    {
        FireCooldownRemaining = FireCooldownRemaining - timeElapsed;

            if (FireCooldownRemaining <= 0f)
            {
                CanFire = true;
                FireOnCooldown = false;
            }
    }

    public void EnableBoost (float activeTime)
    {
        BoostActive = true;
        if (BoostActive == true)
        {
            activeTime = 10f;
        }
    }

    public void DecreaseBoostTimeRemaining (float timeElapsed)
    {
        for (float i = timeElapsed; i <= 10; ++timeElapsed, ++ i)
        {
            BoostTimeRemaining = timeElapsed;
        }
        BoostActive = false;
    }
 
    public bool AddXP(int XPChange)
    {
        if (XPChange >= 0)
        {
            if (BoostActive == true)
            {
                XP = XP + (XPChange * 2);
            }
            else
            {
                XP = XP + XPChange;
            }
        }
        else 
        {
            XP = XP - XPChange;
        }

        if (XP < XPRequiredToNextLevel(Level))
        {
           Level = Level - 1;
        }
        else if (XP > XPRequiredToNextLevel(Level))
        {
            Level = Level + 1;
        }
        else
        {
            Level = Level;
        }

        if (++Level == Level || --Level == Level)
        {
            return true;
        }
        else
        {
            return false;
        }
    }        
}



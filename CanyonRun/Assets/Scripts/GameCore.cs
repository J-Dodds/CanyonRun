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
        if (playerLevel % 2 == 0)
        {
            return playerLevel * 21;                                            //Even levels
        }
        else
        {
            return playerLevel * 20;                                            //Odd levels
        }
    }

    public int XPLossFromMine ( int playerLevel )
    {
        return XP = XP - playerLevel + 2;                                                 //Formula for XP lost when a mine is hit
    }

    public int XPGainFromMine ( int playerLevel )
    {
        return playerLevel + 3;                                                 //Formula for XP gain when a mine is shot
    }

    public int XPGainFromPickup ( int playerLevel )
    {
        return playerLevel + 4;                                                 //Formulae for XP from collecting blue orbs
    }

    public void OnFire()
    {
        if(CanFire == true && FireOnCooldown == false)                          //When called, if player can fire and there is no cooldown, fire and set CanFire to false and start cooldwon
        {
        CanFire = false;
        FireOnCooldown = true;
        FireCooldownRemaining = 0.75f;
        }
    }

    public void DecreaseFireCooldownRemaining(float timeElapsed)
    {
        FireCooldownRemaining = FireCooldownRemaining - timeElapsed;            //When called, reduce FireCooldownRemaining by timeElapsed, and if FireCooldownRemaining is equal to or lower than 0, set CanFire to true and turn off cooldown

            if (FireCooldownRemaining <= 0f)
            {
                CanFire = true;
                FireOnCooldown = false;
            }
    }

    public void EnableBoost (float activeTime)
    {
        BoostActive = true;                                                     //If player hits boost item, sets boost to on for 10 seconds
        BoostTimeRemaining = 10f;
    }

    public void DecreaseBoostTimeRemaining (float timeElapsed)
    {
        BoostTimeRemaining = BoostTimeRemaining - timeElapsed;                   //When called, decrease BoostTimeRemaining by timeElapsed, and if BoostTimeRemaining is equal to or less than 0, deactivates boost
        if (BoostTimeRemaining <= 0f)
        {
            BoostActive = false;
        }
    }
 
    public bool AddXP(int XPChange)
    {
        if (XPChange >= 0)                                                       //If XP gain is greater than 0, checks to see if Boost is active, and if it is, gives double xp, else it just gives normal xp.
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
        else if (XPChange < 0)                                                   //If XP 'gain' is less than 0, player losess xp
        {
            XP = XP - XPChange;
        }

        if (XP < XPRequiredToNextLevel(Level))                                   // If XP is above XP to next level, Level increases
        {
           Level = Level - 1;
           XP = 0;
        }
        else if (XPRequiredToNextLevel(Level) <= 0)
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



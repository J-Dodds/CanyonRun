using UnityEngine;

public class GameCore
{

    public int Level{ get; set; }                                           // Player level
    public int XP { get; set; }                                                     // Total XP
    public bool BoostActive { get; set; }                         // Shows if experience boost is active
    public float BoostTimeRemaining { get; set; }                   // Shows time remaining for boost
    public bool FireOnCooldown { get; set; }                      // Shows if weapons are on cooldown
    public float FireCooldownRemaining { get; set; }                // Shows time remaing until weapon can fire again
    public bool CanFire { get; set; }                             // Shows if weapons can currently be fired

    public float Lerp(float MinV, float MaxV, float Progress)         // From value (MinV), To value (MaxV) and percentage Difference value (Progress)
    {
        return Progress * (MaxV - MinV) + MinV;                        // Progress (0-1) x (Maximum value - Minimum value), where 1 = 100%
    }

    int XPRequiredToNextLevel(int playerLevel)    //XP to next level                  
    {
        if (playerLevel % 2 ==0)
        {
            return playerLevel * 10;            //Even levels
        }
        else
        {
            return playerLevel * 11;            //Odd levels
        }
    }

    public int XPLossFromMine ( int playerLevel )
    {
        return playerLevel * 2;                 //At level 1 lose 2 xp, at 5 lose 10
    }

    public int XPGainFromMine ( int playerLevel )
    {
        return playerLevel * 3;                 //At level 1 gain 3 xp, at 5 gain 15
    }

    public int XPGainFromPickup ( int playerLevel )
    {
        return playerLevel * 4;                 //At level 1 gain 4 xp, at 5 gain 20
    }

    public void OnFire ()
    {
        FireOnCooldown = true;
        CanFire = false;                        //When fired, cannot fire for a time
    }

    public void DecreaseFireCooldownRemaining(int timeElapsed)
    {
        for (int i; i <= 3; ++i)
        {
            timeElapsed = i;
            FireCooldownRemaining = timeElapsed;
        }

        FireOnCooldown = false;
    }

    /* 

        5. Enable Boost
        DecreaseBoostTimeRemaining


 
    public int AddXP(int XPChange)
    {
        if (XPChange => 0)
        {
            if (BoostActive == true)
            {
                return XP + XPChange * 2;
            }
            else
            {
                return AddXP + XPChange;
            }
        }
        else if (XPChange <= 0)
        {
            return AddXP - XPChange;
        }
        else
        {
            --XPChange;
        }
         
        if (XPRequiredToNextLevel <= 0)
        {
            ++Level;
        }
        else if (XPRequiredToNextLevel => XP)
        {
            --Level;
        }

        if (++Level || --Level)
        {
            return true;
        } 
    }
    
        //III. Function returns true if level changes
             
    }
    */
}



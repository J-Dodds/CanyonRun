using UnityEngine;

public class GameCore
{
    public int XP;

    public int Level            // Player level
    {
        get
        {
            return (XP / 10) + 1;  // If called, will return total xp divided by 10 + 1, as the minimum level is 1
        }

        set
        {
            XP = (value + 1) * 10;       // Works out XP based off of the Level
        }
    }
    //public int XP { get; set; }                                                     // Total XP
    //public string BoostActive { get; set; }                         // Shows if experience boost is active
    //public float BoostTimeRemaining { get; set; }                   // Shows time remaining for boost
    //public string FireOnCooldown { get; set; }                      // Shows if weapons are on cooldown
    //public float FireCooldownRemaining { get; set; }                // Shows time remaing until weapon can fire again
    //public string CanFire { get; set; }                             // Shows if weapons can currently be fired

    public float Lerp(float MinV, float MaxV, float Progress)         // From value (MinV), To value (MaxV) and percentage Difference value (Progress)
    {
        return Progress * (MaxV - MinV) + MinV;                        // Progress (0-1) x (Maximum value - Minimum value), where 1 = 100%
    }


    /* 3. XPRequiredToNextLevel
       XPLossFromMine
       XPGainFromMine
       XPGainFromPickup -

        4. OnFire 
        DecreaseFireCooldownRemaining

        5. Enable Boost
        DecreaseBoostTimeRemaining


    
    public int AddXP(int XPChange)
    {
        //I. Positive value must increase
        //II. Negative Value must decrease
        //III. Function returns true if level changes

       
    }
*/
}
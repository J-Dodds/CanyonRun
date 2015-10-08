using UnityEngine;

public class GameCore
{

    public int Level { get; set; }                                                //Current player level
    public int XP { get; set; }                                                   // Total XP
    public bool BoostActive { get; set; }                                         // Shows if experience boost is active
    public float BoostTimeRemaining { get; set; }                                 // Shows time remaining for boost
    public bool FireOnCooldown { get; set; }                                      // Shows if weapons are on cooldown
    public float FireCooldownRemaining { get; set; }                              // Shows time remaing until weapon can fire again
    public string CanFire { get; set; }                                           // Shows if weapons can currently be fired

    public float Lerp(float MinV, float MaxV, float Progress)                     // From value (MinV), To value (MaxV) and percentage Difference value (Progress)
    {
        return Progress * (MaxV - MinV) + MinV;                                   // Progress (0-1) x (Maximum value - Minimum value), where 1 = 100%
    }

    public int XPRequiredToNextLevel (int playerLevel)
    {
        if (player % 2 == 0)
        {
            Level * 11;
        }
        else
        {
            Level * 10;
        }
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
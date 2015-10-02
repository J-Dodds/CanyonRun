﻿using UnityEngine;

public class GameCore 
{
    // from value, to value and percentage between them
    public float Lerp ( float MinV, float MaxV, float Progress)     // From value (MinV), To value (MaxV) and percentage Difference value (Progress)
    {
        return Progress * (MaxV - MinV) + MinV;                     // Progress (0-1) x (Maximum value - Minimum value), where 1 = 100%
    }

    //public int Level { get; set; }                                  // Player level, must be at least 1
    //public int XP { get; set; }                                     // Total experience
    //public string BoostActive { get; set; }                         // Shows if experience boost is active
    //public float BoostTimeRemaining { get; set; }                   // Shows time remaining for boost
    //public string FireOnCooldown { get; set; }                      // Shows if weapons are on cooldown
    //public float FireCooldownRemaining { get; set; }                // Shows time remaing until weapon can fire again
    //public string CanFire { get; set; }                             // Shows if weapons can currently be fired

    //public int XPRequiredToNextLevel (int Level)                    // Whole number of how much xp reqired to reach the next level
    //{
    //    return 25 + (Level * 5);                                    // Formula for xp required. XP to level 2 is 30, level 3 = 35, level 4 = 40
    //}

}

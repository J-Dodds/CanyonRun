using UnityEngine;

public class GameCore 
{
    public int Level { get; set; }                      // Player level, must be at least 1
    public int XP { get; set; }                         // Total experience
    public string BoostActive { get; set; }             // Shows if experience boost is active
    public float BoostTimeRemaining { get; set; }       // Shows time remaining for boost
    public string FireOnCooldown { get; set; }          // Shows if weapons are on cooldown
    public float FireCooldownRemaining { get; set; }    // Shows time remaing until weapon can fire again
    public string CanFire { get; set; }                 // Shows if weapons can currently be fired
}

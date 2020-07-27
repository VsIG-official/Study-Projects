using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides effect utilities
/// </summary>
public static class EffectUtils
{
    /// <summary>
    /// Gets whether or not the speedup effect is active
    /// </summary>
    /// <value><c>true</c> if speedup effect active; otherwise, <c>false</c>.</value>
    public static bool SpeedupEffectActive
    {
        get { return GetSpeedupEffectMonitor().SpeedupEffectActive; }
    }

    /// <summary>
    /// Gets how many seconds are left in the speedup effect
    /// </summary>
    /// <value>speedup effect seconds left</value>
    public static float SpeedupEffectSecondsLeft
    {
        get { return GetSpeedupEffectMonitor().SpeedupEffectSecondsLeft; }
    }

    /// <summary>
    /// Gets the speedup factor for the speedup effect
    /// </summary>
    /// <value>speedup factor</value>
    public static float SpeedupFactor
    {
        get { return GetSpeedupEffectMonitor().SpeedupFactor; }
    }

    /// <summary>
    /// Gets the SpeedupEffectMonitor attached to the main camera
    /// </summary>
    /// <returns>speedup effect monitor</returns>
    static SpeedupEffectMonitor GetSpeedupEffectMonitor()
    {
        return Camera.main.GetComponent<SpeedupEffectMonitor>();
    }
}

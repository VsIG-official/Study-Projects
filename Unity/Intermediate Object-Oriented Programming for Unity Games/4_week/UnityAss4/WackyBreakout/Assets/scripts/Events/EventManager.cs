using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// An event manager
/// </summary>
public static class EventManager
{
    // FreezerEffectActivated support
    static List<PickupBlock> freezerEffectInvokers = new List<PickupBlock>();
    static List<UnityAction<float>> freezerEffectListeners = 
        new List<UnityAction<float>>();

    // speedupEffectActivated support
    static List<PickupBlock> speedupEffectInvokers = new List<PickupBlock>();
    static List<UnityAction<float, float>> speedupEffectListeners = 
        new List<UnityAction<float, float>>();
    
    #region Public methods

    /// <summary>
    /// Adds the given script as a freezer effect invoker
    /// </summary>
    /// <param name="invoker">invoker</param>
    public static void AddFreezerEffectInvoker(PickupBlock invoker)
    {
        // add invoker to list and add all listeners to invoker
        freezerEffectInvokers.Add(invoker);
        foreach (UnityAction<float> listener in freezerEffectListeners)
        {
            invoker.AddFreezerEffectListener(listener);
        }
    }

    /// <summary>
    /// Adds the given method as a freezer effect listener
    /// </summary>
    /// <param name="listener">listener</param>
    public static void AddFreezerEffectListener(UnityAction<float> listener)
    {
        // add listener to list and to all invokers
        freezerEffectListeners.Add(listener);
        foreach (PickupBlock invoker in freezerEffectInvokers)
        {
            invoker.AddFreezerEffectListener(listener);
        }
    }

    /// <summary>
    /// Adds the given script as a speedup effect invoker
    /// </summary>
    /// <param name="invoker">invoker</param>
    public static void AddSpeedupEffectInvoker(PickupBlock invoker)
    {
        // add invoker to list and add all listeners to invoker
        speedupEffectInvokers.Add(invoker);
        foreach (UnityAction<float, float> listener in speedupEffectListeners)
        {
            invoker.AddSpeedupEffectListener(listener);
        }
    }

    /// <summary>
    /// Adds the given method as a speedup effect listener
    /// </summary>
    /// <param name="listener">listener</param>
    public static void AddSpeedupEffectListener(UnityAction<float, float> listener)
    {
        // add listener to list and to all invokers
        speedupEffectListeners.Add(listener);
        foreach (PickupBlock invoker in speedupEffectInvokers)
        {
            invoker.AddSpeedupEffectListener(listener);
        }
    }

    #endregion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A pirate launcher
/// </summary>
public class PirateLauncher : Launcher
{
    /// <summary>
    /// Use this for initialization
    /// </summary>
    override protected void Start()
    {
        cooldownSeconds = 1f;
        base.Start();
    }
}

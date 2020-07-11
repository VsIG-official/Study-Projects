using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

/// <summary>
/// Provides access to configuration data
/// </summary>
public static class ConfigurationUtils
{
	private static ConfigurationData data;

    /// <summary>
    /// Gets the teddy bear move units per second
    /// </summary>
    /// <value>teddy bear move units per second</value>
    public static float TeddyBearMoveUnitsPerSecond
    {
        get { return data.TeddyBearMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the cooldown seconds for shooting
    /// </summary>
    /// <value>cooldown seconds</value>
    public static float CooldownSeconds
    {
        get { return data.CooldownSeconds; }
    }

    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {
	    data = new ConfigurationData();
    }
}

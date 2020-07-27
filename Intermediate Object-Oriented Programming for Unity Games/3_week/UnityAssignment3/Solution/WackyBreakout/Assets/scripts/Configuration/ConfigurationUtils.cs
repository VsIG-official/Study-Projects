using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides access to configuration data
/// </summary>
public static class ConfigurationUtils
{
    static ConfigurationData configurationData;

    #region Properties

    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public static float PaddleMoveUnitsPerSecond
    {
        get { return configurationData.PaddleMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the impulse force to apply to move the ball
    /// </summary>
    /// <value>impulse force</value>
    public static float BallImpulseForce
    {
        get { return configurationData.BallImpulseForce; }
    }

    /// <summary>
    /// Gets the number of seconds the ball lives
    /// </summary>
    /// <value>ball life seconds</value>
    public static float BallLifeSeconds
    {
        get { return configurationData.BallLifeSeconds; }
    }

    /// <summary>
    /// Gets the minimum number of seconds for a ball spawn
    /// </summary>
    /// <value>minimum spawn seconds</value>
    public static float MinSpawnSeconds
    {
        get { return configurationData.MinSpawnSeconds; }    
    }

    /// <summary>
    /// Gets the maximum number of seconds for a ball spawn
    /// </summary>
    /// <value>maximum spawn seconds</value>
    public static float MaxSpawnSeconds
    {
        get { return configurationData.MaxSpawnSeconds; }    
    }

    /// <summary>
    /// Gets the number of points a standard block is worth
    /// </summary>
    /// <value>standard block points</value>
    public static int StandardBlockPoints
    {
        get { return configurationData.StandardBlockPoints; }    
    }

    /// <summary>
    /// Gets the number of points a bonus block is worth
    /// </summary>
    /// <value>bonus block points</value>
    public static int BonusBlockPoints
    {
        get { return configurationData.BonusBlockPoints; }    
    }

    /// <summary>
    /// Gets the number of points a pickup block is worth
    /// </summary>
    /// <value>pickup block points</value>
    public static int PickupBlockPoints
    {
        get { return configurationData.PickupBlockPoints; }    
    }

    /// <summary>
    /// Gets the probability that a standard block
    /// will be added to the level
    /// </summary>
    /// <value>standard block probability</value>
    public static float StandardBlockProbability
    {
        get { return configurationData.StandardBlockProbability; }    
    }

    /// <summary>
    /// Gets the probability that a bonus block
    /// will be added to the level
    /// </summary>
    /// <value>bonus block probability</value>
    public static float BonusBlockProbability
    {
        get { return configurationData.BonusBlockProbability; }    
    }

    /// <summary>
    /// Gets the probability that a freezer block
    /// will be added to the level
    /// </summary>
    /// <value>freezer block probability</value>
    public static float FreezerBlockProbability
    {
        get { return configurationData.FreezerBlockProbability; }    
    }

    /// <summary>
    /// Gets the probability that a speedup block
    /// will be added to the level
    /// </summary>
    /// <value>speedup block probability</value>
    public static float SpeedupBlockProbability
    {
        get { return configurationData.SpeedupBlockProbability; }    
    }

    /// <summary>
    /// Gets the number of balls per game
    /// </summary>
    /// <value>balls per game</value>
    public static int BallsPerGame
    {
        get { return configurationData.BallsPerGame; }    
    }

    /// <summary>
    /// Gets the duration of the freezer effect
    /// in seconds
    /// </summary>
    /// <value>freezer seconds</value>
    public static float FreezerSeconds
    {
        get { return configurationData.FreezerSeconds; }    
    }
        
    /// <summary>
    /// Gets the speedup factor
    /// </summary>
    /// <value>speedup factor</value>
    public static float SpeedupFactor
    {
        get { return configurationData.SpeedupFactor; }    
    }

    /// <summary>
    /// Gets the duration of the speedup effect
    /// in seconds
    /// </summary>
    /// <value>speedup seconds</value>
    public static float SpeedupSeconds
    {
        get { return configurationData.SpeedupSeconds; }    
    }

    #endregion

    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {
        configurationData = new ConfigurationData();
    }

}

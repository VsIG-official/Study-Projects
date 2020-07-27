using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

/// <summary>
/// A container for the configuration data
/// </summary>
public class ConfigurationData
{
    #region Fields

    const string ConfigurationDataFileName = "ConfigurationData.csv";

    // configuration data
    float paddleMoveUnitsPerSecond = 10;
    float ballImpulseForce = 200;
    float ballLifeSeconds = 10;
    float minSpawnSeconds = 5;
    float maxSpawnSeconds = 10;
    int standardBlockPoints = 1;
    int bonusBlockPoints = 2;
    int pickupBlockPoints = 5;
    float standardBlockProbability = 0.7f;
    float bonusBlockProbability = 0.2f;
    float freezerBlockProbability = 0.05f;
    float speedupBlockProbability = 0.05f;
    int ballsPerGame = 5;
    float freezerSeconds = 2;
    float speedupFactor = 2;
    float speedupSeconds = 2;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public float PaddleMoveUnitsPerSecond
    {
        get { return paddleMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the impulse force to apply to move the ball
    /// </summary>
    /// <value>impulse force</value>
    public float BallImpulseForce
    {
        get { return ballImpulseForce; }
    }

    /// <summary>
    /// Gets the number of seconds the ball lives
    /// </summary>
    /// <value>ball life seconds</value>
    public float BallLifeSeconds
    {
        get { return ballLifeSeconds; }
    }

    /// <summary>
    /// Gets the minimum number of seconds for a ball spawn
    /// </summary>
    /// <value>minimum spawn seconds</value>
    public float MinSpawnSeconds
    {
        get { return minSpawnSeconds; }    
    }

    /// <summary>
    /// Gets the maximum number of seconds for a ball spawn
    /// </summary>
    /// <value>maximum spawn seconds</value>
    public float MaxSpawnSeconds
    {
        get { return maxSpawnSeconds; }    
    }

    /// <summary>
    /// Gets the number of points a standard block is worth
    /// </summary>
    /// <value>standard block points</value>
    public int StandardBlockPoints
    {
        get { return standardBlockPoints; }    
    }

    /// <summary>
    /// Gets the number of points a bonus block is worth
    /// </summary>
    /// <value>bonus block points</value>
    public int BonusBlockPoints
    {
        get { return bonusBlockPoints; }    
    }

    /// <summary>
    /// Gets the number of points a pickup block is worth
    /// </summary>
    /// <value>pickup block points</value>
    public int PickupBlockPoints
    {
        get { return pickupBlockPoints; }    
    }

    /// <summary>
    /// Gets the probability that a standard block
    /// will be added to the level
    /// </summary>
    /// <value>standard block probability</value>
    public float StandardBlockProbability
    {
        get { return standardBlockProbability; }    
    }

    /// <summary>
    /// Gets the probability that a bonus block
    /// will be added to the level
    /// </summary>
    /// <value>bonus block probability</value>
    public float BonusBlockProbability
    {
        get { return bonusBlockProbability; }    
    }

    /// <summary>
    /// Gets the probability that a freezer block
    /// will be added to the level
    /// </summary>
    /// <value>freezer block probability</value>
    public float FreezerBlockProbability
    {
        get { return freezerBlockProbability; }    
    }

    /// <summary>
    /// Gets the probability that a speedup block
    /// will be added to the level
    /// </summary>
    /// <value>speedup block probability</value>
    public float SpeedupBlockProbability
    {
        get { return speedupBlockProbability; }    
    }

    /// <summary>
    /// Gets the number of balls per game
    /// </summary>
    /// <value>balls per game</value>
    public int BallsPerGame
    {
        get { return ballsPerGame; }    
    }

    /// <summary>
    /// Gets the duration of the freezer effect
    /// in seconds
    /// </summary>
    /// <value>freezer seconds</value>
    public float FreezerSeconds
    {
        get { return freezerSeconds; }    
    }

    /// <summary>
    /// Gets the speedup factor
    /// </summary>
    /// <value>speedup factor</value>
    public float SpeedupFactor
    {
        get { return speedupFactor; }    
    }

    /// <summary>
    /// Gets the duration of the speedup effect
    /// in seconds
    /// </summary>
    /// <value>speedup seconds</value>
    public float SpeedupSeconds
    {
        get { return speedupSeconds; }    
    }

    #endregion

    #region Constructor

    /// <summary>
    /// Constructor
    /// Reads configuration data from a file. If the file
    /// read fails, the object contains default values for
    /// the configuration data
    /// </summary>
    public ConfigurationData()
    {
        // read and save configuration data from file
        StreamReader input = null;
        try
        {
            // create stream reader object
            input = File.OpenText(Path.Combine(
                Application.streamingAssetsPath, ConfigurationDataFileName));

            // read in names and values
            string names = input.ReadLine();
            string values = input.ReadLine();

            // set configuration data fields
            SetConfigurationDataFields(values);
        }
        catch (Exception e)
        {
        }
        finally
        {
            // always close input file
            if (input != null)
            {
                input.Close();
            }
        }
    }

    #endregion

    /// <summary>
    /// Sets the configuration data fields from the provided
    /// csv string
    /// </summary>
    /// <param name="csvValues">csv string of values</param>
    void SetConfigurationDataFields(string csvValues)
    {
        // the code below assumes we know the order in which the
        // values appear in the string. We could do something more
        // complicated with the names and values, but that's not
        // necessary here
        string[] values = csvValues.Split(',');
        paddleMoveUnitsPerSecond = float.Parse(values[0]);
        ballImpulseForce = float.Parse(values[1]);
        ballLifeSeconds = float.Parse(values[2]);
        minSpawnSeconds = float.Parse(values[3]);
        maxSpawnSeconds = float.Parse(values[4]);
        standardBlockPoints = int.Parse(values[5]);
        bonusBlockPoints = int.Parse(values[6]);
        pickupBlockPoints = int.Parse(values[7]);
        standardBlockProbability = float.Parse(values[8]) / 100;
        bonusBlockProbability = float.Parse(values[9]) / 100;
        freezerBlockProbability = float.Parse(values[10]) / 100;
        speedupBlockProbability = float.Parse(values[11]) / 100;
        ballsPerGame = int.Parse(values[12]);
        freezerSeconds = float.Parse(values[13]);
        speedupFactor = float.Parse(values[14]);
        speedupSeconds = float.Parse(values[15]);
    }
}

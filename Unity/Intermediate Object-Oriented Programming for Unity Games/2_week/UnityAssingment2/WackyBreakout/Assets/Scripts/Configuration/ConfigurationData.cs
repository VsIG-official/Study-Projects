using System;
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
	private float paddleMoveUnitsPerSecond = 10;
	private float ballImpulseForce = 200;
	private float ballLifetime = 10;
    private float minSpawnSeconds = 5;
	private float maxSpawnSeconds = 10;

    #endregion

    #region Properties

    // but You can use auto property (probably will use it in next assignment):
    /*
    *delete private float paddleMoveUnitsPerSecond = 10; and add:
    public float PaddleMoveUnitsPerSecond { get; private set; } = 10;
    */

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
    /// Gets the lifetime
    /// </summary>
    /// <value>impulse force</value>
    public float BallLifetime
    {
	    get { return ballLifetime; }
    }

    /// <summary>
    /// Gets the min seconds to spawn
    /// </summary>
    /// <value>impulse force</value>
    public float MinSpawnSeconds
    {
	    get { return minSpawnSeconds; }
    }

    /// <summary>
    /// Gets the max seconds to spawn
    /// </summary>
    /// <value>impulse force</value>
    public float MaxSpawnSeconds
    {
	    get { return maxSpawnSeconds; }
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
            SetConfigurationDataFields(names,values);
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


    /// <summary>
    /// Sets the configuration data fields from the provided
    /// csv string
    /// </summary>
    /// <param name="csvValues">csv string of values</param>
    void SetConfigurationDataFields(string csvNames,string csvValues)
    {
        // the code below assumes we know the order in which the
        // values appear in the string. We could do something more
        // complicated with the names and values, but that's not
        // necessary here
        string[] names = csvNames.Split(',');
        string[] values = csvValues.Split(',');

        // will use there loop instead of paddleMoveUnitsPerSecond = float.Parse(values[0]);
        for (int i = 0; i <= values.Length; i++)
        {
			names[i] = values[i];
        }

        /*
        paddleMoveUnitsPerSecond = float.Parse(values[0]);
        ballImpulseForce = float.Parse(values[1]);
        ballLifetime = float.Parse(values[2]);
        minSpawnSeconds = float.Parse(values[3]);
        maxSpawnSeconds = float.Parse(values[4]);
        */
    }

    #endregion
}

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

    // configuration data with default values
    static float teddyBearMoveUnitsPerSecond = 5;
    private static float cooldownSeconds = 1;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the teddy bear move units per second
    /// </summary>
    /// <value>teddy bear move units per second</value>
    public float TeddyBearMoveUnitsPerSecond
    {
        get { return teddyBearMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the cooldown seconds for shooting
    /// </summary>
    /// <value>cooldown seconds</value>
    public float CooldownSeconds
    {
        get { return cooldownSeconds; }
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
            //takes firstly path to the object and then object itself
	        input = File.OpenText(Path.Combine(
		        Application.streamingAssetsPath, ConfigurationDataFileName));

	        string names = input.ReadLine();
	        string values = input.ReadLine();

	        // set configuration data fields
	        SetConfigurationDataFields(values);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
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
    static void SetConfigurationDataFields(string csvValues)
    {
	    string[] values = csvValues.Split(',');
	    teddyBearMoveUnitsPerSecond = float.Parse(values[0]);
	    cooldownSeconds = float.Parse(values[1]);
    }

    #endregion Constructor
}

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
    /// Gets the impulse force to apply to move the ball
    /// </summary>
    /// <value>impulse force</value>
    public static float BallLifetime
    {
	    get { return configurationData.BallLifetime; }
    }

    /// <summary>
    /// Gets the min seconds to spawn
    /// </summary>
    /// <value>impulse force</value>
    public static float MinSpawnSeconds
    {
	    get { return configurationData.MinSpawnSeconds; }
    }

    /// <summary>
    /// Gets the max seconds to spawn
    /// </summary>
    /// <value>impulse force</value>
    public static float MaxSpawnSeconds
    {
	    get { return configurationData.MaxSpawnSeconds; }
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

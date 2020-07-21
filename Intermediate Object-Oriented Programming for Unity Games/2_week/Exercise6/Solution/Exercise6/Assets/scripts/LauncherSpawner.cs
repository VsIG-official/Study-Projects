using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A launcher spawner
/// </summary>
public class LauncherSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabChainsawLauncher;
    [SerializeField]
    GameObject prefabPirateLauncher;
    [SerializeField]
    GameObject prefabZombieLauncher;

    // spawn support
    Timer spawnTimer;

    // spawn order support
    bool chainsawLauncherSpawned = false;
    bool pirateLauncherSpawned = false;
    bool zombieLauncherSpawned = false;
    bool doneSpawning = false;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
		// create and start spawn timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = 5;
        spawnTimer.Run();
    }
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		// spawn launcher and restart timer as appropriate
        if (!doneSpawning && spawnTimer.Finished)
        {
            if (!chainsawLauncherSpawned)
            {
                Instantiate(prefabChainsawLauncher);
                chainsawLauncherSpawned = true;
            }
            else if (!pirateLauncherSpawned)
            {
                Instantiate(prefabPirateLauncher);
                pirateLauncherSpawned = true;
            }
            else if (!zombieLauncherSpawned)
            {
                Instantiate(prefabZombieLauncher);
                zombieLauncherSpawned = true;
                doneSpawning = true;
            }

            // restart timer if more launchers to spawn
            if (!doneSpawning)
            {
                spawnTimer.Run();
            }
        }
	}
}

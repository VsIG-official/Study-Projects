using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class BallSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabBall;

    // spawn support
    Vector2 spawnLocation = new Vector2(0, -1.5f);
    Timer spawnTimer;
    float spawnRange;

    // collision-free support
    bool retrySpawn = false;
    Vector2 spawnLocationMin;
    Vector2 spawnLocationMax;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        // spawn and destroy ball to calculate
        // spawn location min and max
        GameObject tempBall = Instantiate<GameObject>(prefabBall);
        BoxCollider2D collider = tempBall.GetComponent<BoxCollider2D>();
        float ballColliderHalfWidth = collider.size.x / 2;
        float ballColliderHalfHeight = collider.size.y / 2;
        spawnLocationMin = new Vector2(
            tempBall.transform.position.x - ballColliderHalfWidth,
            tempBall.transform.position.y - ballColliderHalfHeight);
        spawnLocationMax = new Vector2(
            tempBall.transform.position.x + ballColliderHalfWidth,
            tempBall.transform.position.y + ballColliderHalfHeight);
        Destroy(tempBall);

		// initialize and start spawn timer
        spawnRange = ConfigurationUtils.MaxSpawnSeconds -
            ConfigurationUtils.MinSpawnSeconds;
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.AddTimerFinishedListener(HandleSpawnTimerFinished);
        spawnTimer.Duration = GetSpawnDelay();
        spawnTimer.Run();

        // listen for lost and dead ball events
        EventManager.AddBallLostListener(SpawnBall);
        EventManager.AddBallDiedListener(SpawnBall);

        // spawn first ball in game
        SpawnBall();
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        // try again if spawn still pending
        if (retrySpawn)
        {
            SpawnBall();
        }
	}

    /// <summary>
    /// Spawns a ball
    /// </summary>
    void SpawnBall()
    {
        // don't stack with a spawn still pending
        retrySpawn = false;

        // make sure we don't spawn into a collision
        if (Physics2D.OverlapArea(spawnLocationMin, spawnLocationMax) == null)
        {
            Instantiate(prefabBall);
            AudioManager.Play(AudioClipName.BallSpawn);
        }
        else
        {
            retrySpawn = true;
        }
    }

    /// <summary>
    /// Gets the spawn delay in seconds for the next ball spawn
    /// </summary>
    /// <returns>spawn delay</returns>
    float GetSpawnDelay()
    {
        return ConfigurationUtils.MinSpawnSeconds +
            Random.value * spawnRange;
    }

    /// <summary>
    /// Handles when the spawn timer finishes
    /// </summary>
    void HandleSpawnTimerFinished()
    {
        SpawnBall();
        spawnTimer.Duration = GetSpawnDelay();
        spawnTimer.Run();
    }
}

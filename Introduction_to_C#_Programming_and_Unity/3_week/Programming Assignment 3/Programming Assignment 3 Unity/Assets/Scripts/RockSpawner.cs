using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A rock spawner
/// </summary>
public class RockSpawner : MonoBehaviour
{
	// needed for spawning
	[SerializeField]
	GameObject prefabRock;

	// saved for efficiency
	[SerializeField]
	Sprite rockSprite0;
	[SerializeField]
	Sprite rockSprite1;
	[SerializeField]
	Sprite rockSprite2;

	// spawn control
	const float MinSpawnDelay = 1;
	const float MaxSpawnDelay = 2;
	Timer spawnTimer;

	// spawn location support
	const int SpawnBorderSize = 100;
	int minSpawnX;
	int maxSpawnX;
	int minSpawnY;
	int maxSpawnY;

	//for counting rocks
	int rockCount = 0;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
		// save spawn boundaries for efficiency
		minSpawnX = SpawnBorderSize;
		maxSpawnX = Screen.width - SpawnBorderSize;
		minSpawnY = SpawnBorderSize;
		maxSpawnY = Screen.height - SpawnBorderSize;

		// create and start timer
		spawnTimer = gameObject.AddComponent<Timer>();
		spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
		spawnTimer.Run();
	}

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		// check for time to spawn a new teddy bear
		if (spawnTimer.Finished)
		{
			rockCount = GameObject.FindGameObjectsWithTag("Rock").Length;
			SpawnRock();

				// change spawn timer duration and restart
				spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
				spawnTimer.Run();
		}
	}

	/// <summary>
	/// Spawns a new teddy bear at a random location
	/// </summary>
	void SpawnRock()
	{
		if (rockCount < 3)
		{
			// generate random location and create new teddy bear
			Vector3 location = new Vector3(Random.Range(minSpawnX, maxSpawnX),
									   Random.Range(minSpawnY, maxSpawnY),
									   -Camera.main.transform.position.z);
			Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
			GameObject rock = Instantiate(prefabRock) as GameObject;
			rock.transform.position = worldLocation;

			// set random sprite for new teddy bear
			SpriteRenderer spriteRenderer = rock.GetComponent<SpriteRenderer>();
			int spriteNumber = Random.Range(0, 3);
			if (spriteNumber == 0)
			{
				spriteRenderer.sprite = rockSprite0;
			}
			else if (spriteNumber == 1)
			{
				spriteRenderer.sprite = rockSprite1;
			}
			else
			{
				spriteRenderer.sprite = rockSprite2;
			}
		}
	}
}

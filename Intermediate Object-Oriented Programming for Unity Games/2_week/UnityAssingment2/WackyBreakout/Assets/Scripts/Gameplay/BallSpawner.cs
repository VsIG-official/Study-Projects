using UnityEditor;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
	[SerializeField] private GameObject ballPrefab;
	private Timer timer;
	float spawnRange;
	private bool retryToSpawn = false;
	private BoxCollider2D rb2d;
	private float halfWidthOfCollider;
	private float halfHeightOfCollider;
	private Vector2 minSpawnLocation;
	private Vector2 maxSpawnLocation;

	void Start()
	{
		GameObject tempBall = Instantiate(ballPrefab);
		rb2d = tempBall.GetComponent<BoxCollider2D>();
		halfWidthOfCollider = rb2d.size.x / 2;
		halfHeightOfCollider = rb2d.size.y / 2;
		minSpawnLocation = new Vector2(tempBall.transform.position.x - halfWidthOfCollider,
			tempBall.transform.position.y - halfHeightOfCollider);
		maxSpawnLocation = new Vector2(tempBall.transform.position.x + halfWidthOfCollider,
			tempBall.transform.position.y + halfHeightOfCollider);
		Destroy(tempBall);

		spawnRange = ConfigurationUtils.MaxSpawnSeconds -
		             ConfigurationUtils.MinSpawnSeconds;
		timer = gameObject.AddComponent<Timer>();
		timer.Duration = GetSpawnDelay();
		timer.Run();

		SpawnBall();
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

	public void SpawnBall()
	{
		if (Physics2D.OverlapArea(minSpawnLocation,maxSpawnLocation) == null)
		{
			retryToSpawn = false;
			Instantiate(ballPrefab);
		}
		else
		{
			retryToSpawn = true;
		}
	}

	void Update()
	{
		if (timer.Finished)
		{
			retryToSpawn = false;
			SpawnBall();
			timer.Duration = GetSpawnDelay();
			timer.Run();
		}
		if (retryToSpawn)
		{
			SpawnBall();
		}
	}
}

using UnityEngine;

public class BallSpawner : MonoBehaviour
{
	[SerializeField] private GameObject ballPrefab;
	private Timer timer;
	float spawnRange;
	private bool retryToSpawn;
	private BoxCollider2D rb2d;
	private float halfWidthOfCollider;
	private float halfHeightOfCollider;

	void Start()
	{
		rb2d = GetComponent<BoxCollider2D>();
		halfWidthOfCollider = rb2d.size.x / 2;
		halfHeightOfCollider = rb2d.size.y / 2;

		timer = gameObject.AddComponent<Timer>();
		spawnRange = ConfigurationUtils.MaxSpawnSeconds -
		             ConfigurationUtils.MinSpawnSeconds;
		timer.Duration = GetSpawnDelay();
		timer.Run();
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
		if (Physics2D.OverlapArea(new Vector2(rb2d.size.x, rb2d.size.y),
			new Vector2(0, 0)) == null)
		{
			Instantiate(ballPrefab);
		}
		else
		{
			Instantiate(ballPrefab, new Vector3(rb2d.size.x * 2,
				rb2d.size.y * 2, 0),Quaternion.identity);
		}
	}

	void Update()
	{
		if (timer.Finished)
		{
			SpawnBall();
			timer.Duration = GetSpawnDelay();
			timer.Run();
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
///
/// </summary>
public class BallSpawner : MonoBehaviour
{
	[SerializeField] private GameObject whiteBall;
	[SerializeField] private GameObject redBall;
	[SerializeField] private GameObject greenBall;

	Timer spawnTimer;

	List<GameObject> balls = new List<GameObject>();

	// Start is called before the first frame update
	void Start()
    {
	    spawnTimer = gameObject.AddComponent<Timer>();
	    spawnTimer.Duration = 1;
        spawnTimer.Run();

        balls.Add(whiteBall);
        balls.Add(redBall);
        balls.Add(greenBall);
	}

    // Update is called once per frame
    void Update()
    {
	    if (spawnTimer.Finished)
	    {
		    spawnTimer.Duration = 1;
		    spawnTimer.Run();

			// without LinQ
		    Instantiate(balls[Random.Range(0, balls.Count)]);

		    // with LinQ
			//Instantiate(balls.ElementAt(Random.Range(0, balls.Count)));
	    }
    }
}

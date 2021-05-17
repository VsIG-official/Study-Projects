using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A ball spawner
/// </summary>
public class BallSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabBall;
    [SerializeField]
    GameObject prefabGreenBall;
    [SerializeField]
    GameObject prefabRedBall;

    Timer spawnTimer;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
		// add spawn timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = 1;
        spawnTimer.Run();
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		// spawn ball and restart timer as appropriate
        if (spawnTimer.Finished)
        {
            spawnTimer.Run();
            int ballType = Random.Range(0, 3);
            if (ballType == 0)
            {
                Instantiate(prefabBall);
            }
            else if (ballType == 1)
            {
                Instantiate(prefabGreenBall);
            }
            else
            {
                Instantiate(prefabRedBall);
            }
        }
	}
}

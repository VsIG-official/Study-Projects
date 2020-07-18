using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Launcher spawner
/// </summary>
public class LauncherSpawner : MonoBehaviour
{
	[SerializeField] private GameObject chainsawPrefab;
	[SerializeField] private GameObject piratePrefab;
	[SerializeField] private GameObject zombiePrefab;
	private Timer timer;
	List<GameObject> launchers = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
	    timer = gameObject.AddComponent<Timer>();
	    timer.Duration = 5f;
        timer.Run();

        launchers.Add(chainsawPrefab);
        launchers.Add(piratePrefab);
        launchers.Add(zombiePrefab);
    }

    // Update is called once per frame
    void Update()
    {
	    if (timer.Finished)
	    {
		    int newLauncher = Random.Range(0, launchers.Count);
			Instantiate(launchers[newLauncher]);
			launchers.RemoveAt(newLauncher);

			timer.Duration = 5f;
		    timer.Run();
		}

	    else if (launchers.Count == 0)
	    {
			Debug.Log("Nothing to spawn");
	    }
    }
}

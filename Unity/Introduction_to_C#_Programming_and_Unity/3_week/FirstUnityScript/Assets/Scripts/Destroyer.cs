using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// destroys c4 teddy bears
/// </summary>
public class Destroyer : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;
    // Start is called before the first frame update
    Timer explodeTimer;
    private void Start()
    {
        explodeTimer = gameObject.AddComponent<Timer>();
        explodeTimer.Duration = 1;
        explodeTimer.Run();
    }
    // Update is called once per frame
    void Update()
    {
        if (explodeTimer.Finished)
        {
            explodeTimer.Run();
        GameObject teddy = GameObject.FindWithTag("C4TeddyBear");
        if (teddy!=null)
        {
            Instantiate<GameObject>(prefabExplosion, teddy.transform.position, Quaternion.identity);
            Destroy(teddy);
        }
        }
    }
}

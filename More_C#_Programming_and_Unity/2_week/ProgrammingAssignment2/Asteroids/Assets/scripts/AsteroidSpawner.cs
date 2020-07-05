using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class for spawning asteroids
/// </summary>
public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabAsteroid;

    // Start is called before the first frame update
    void Start()
    {
        GameObject asteroid = Instantiate(prefabAsteroid);
        float radius = asteroid.GetComponent<CircleCollider2D>().radius;
        Destroy(asteroid);

        GameObject asteroidLeft = Instantiate(prefabAsteroid);
        asteroidLeft.GetComponent<Asteroid>().Initialize(Direction.Left,new Vector2
            (ScreenUtils.ScreenRight + radius,
            (ScreenUtils.ScreenTop + ScreenUtils.ScreenBottom) / 2));

        GameObject asteroidRight = Instantiate(prefabAsteroid);
        asteroidRight.GetComponent<Asteroid>().Initialize(Direction.Right, new Vector2
            (ScreenUtils.ScreenLeft - radius,
            (ScreenUtils.ScreenTop + ScreenUtils.ScreenBottom) / 2));

        GameObject asteroidTop = Instantiate(prefabAsteroid);
        asteroidTop.GetComponent<Asteroid>().Initialize(Direction.Down, new Vector2
            ((ScreenUtils.ScreenLeft + ScreenUtils.ScreenRight) / 2,
            ScreenUtils.ScreenTop + radius));

        GameObject asteroidDown = Instantiate(prefabAsteroid);
        asteroidDown.GetComponent<Asteroid>().Initialize(Direction.Up, new Vector2
            ((ScreenUtils.ScreenLeft + ScreenUtils.ScreenRight) / 2,
            ScreenUtils.ScreenBottom - radius));
    }
}

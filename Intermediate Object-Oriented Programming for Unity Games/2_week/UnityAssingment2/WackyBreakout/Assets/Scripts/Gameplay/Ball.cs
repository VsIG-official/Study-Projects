using UnityEngine;

/// <summary>
/// A ball
/// </summary>
public class Ball : MonoBehaviour
{
	private Timer deathTimer;
	private Timer moveTimer;

	private BoxCollider2D rb2d;
	private float halfColliderHeight;

	private HUDScript hudScript;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
		rb2d = GetComponent<BoxCollider2D>();
		halfColliderHeight = rb2d.size.y / 2;

		deathTimer = gameObject.AddComponent<Timer>();
		moveTimer = gameObject.AddComponent<Timer>();

		moveTimer.Duration = 1f;
        deathTimer.Duration = ConfigurationUtils.BallLifetime;

        moveTimer.Run();
        deathTimer.Run();

        HUDScript.AddBalls();
	}

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		if (moveTimer.Finished)
		{
			moveTimer.Stop();
			StartMoving();
		}
		if (deathTimer.Finished)
		{
			Camera.main.GetComponent<BallSpawner>().SpawnBall();
            Destroy(gameObject);
		}
	}

	/// <summary>
	/// Starts the moving.
	/// </summary>
	void StartMoving()
	{
		// get the ball moving
		float angle = -90 * Mathf.Deg2Rad;
		Vector2 force = new Vector2(
			ConfigurationUtils.BallImpulseForce * Mathf.Cos(angle),
			ConfigurationUtils.BallImpulseForce * Mathf.Sin(angle));
		GetComponent<Rigidbody2D>().AddForce(force);
	}

    /// <summary>
    /// Sets the ball direction to the given direction
    /// </summary>
    /// <param name="direction">direction</param>
    public void SetDirection(Vector2 direction)
    {
        // get current rigidbody speed
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        float speed = rb2d.velocity.magnitude;
        rb2d.velocity = direction * speed;
    }

    void OnBecameInvisible()
    {
	    if (!deathTimer.Finished && transform.position.y - halfColliderHeight < ScreenUtils.ScreenBottom)
	    {
		    Camera.main.GetComponent<BallSpawner>().SpawnBall();
		}

	    HUDScript.ReduceBalls();
		Destroy(gameObject);
	}
}

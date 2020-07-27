using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// A ball
/// </summary>
public class Ball : MonoBehaviour
{
    // move delay timer
    Timer moveTimer;

    // ball death support
    Timer deathTimer;
    BallDied ballDied;

    // speedup effect support
    Rigidbody2D rb2d;
    Timer speedupTimer;
    float speedupFactor;

    // lost ball support
    BallLost ballLost;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        // start move timer
        moveTimer = gameObject.AddComponent<Timer>();
        moveTimer.Duration = 1;
        moveTimer.AddTimerFinishedListener(HandleMoveTimerFinished);
        moveTimer.Run();

        // start death timer
        deathTimer = gameObject.AddComponent<Timer>();
        deathTimer.Duration = ConfigurationUtils.BallLifeSeconds;
        deathTimer.AddTimerFinishedListener(HandleDeathTimerFinished);
        deathTimer.Run();

        // ball death support
        ballDied = new BallDied();
        EventManager.AddBallDiedInvoker(this);

        // lost ball support
        ballLost = new BallLost();
        EventManager.AddBallLostInvoker(this);

        // speedup effect support
        speedupTimer = gameObject.AddComponent<Timer>();
        speedupTimer.AddTimerFinishedListener(HandleSpeedupTimerFinished);
        EventManager.AddSpeedupEffectListener(HandleSpeedupEffectActivatedEvent);
        rb2d = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
	{

	}

    /// <summary>
    /// Spawn new ball and destroy self when out of game
    /// </summary>
    void OnBecameInvisible()
    {
        // death timer destruction is in the listener for the death timer
        if (!deathTimer.Finished)
        {
            // only lost ball if below screen
            float halfColliderHeight = 
                gameObject.GetComponent<BoxCollider2D>().size.y / 2;
            if (transform.position.y - halfColliderHeight < ScreenUtils.ScreenBottom)
            {
                AudioManager.Play(AudioClipName.BallLost);
                ballLost.Invoke();
            }
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Plays collision sound effect as appropriate
    /// </summary>
    /// <param name="coll">collision info.</param>
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ball") ||
            coll.gameObject.CompareTag("Block") ||
            coll.gameObject.CompareTag("Paddle"))
        {
            AudioManager.Play(AudioClipName.BallCollision);
        }
    }

    /// <summary>
    /// Starts the ball moving
    /// </summary>
    void StartMoving()
    {
        // calculate force to apply
        float angle = -90 * Mathf.Deg2Rad;
        Vector2 force = new Vector2(
            ConfigurationUtils.BallImpulseForce * Mathf.Cos(angle),
            ConfigurationUtils.BallImpulseForce * Mathf.Sin(angle));

        // adjust as necessary if speedup effect is active
        if (EffectUtils.SpeedupEffectActive)
        {
            StartSpeedupEffect(EffectUtils.SpeedupEffectSecondsLeft,
                EffectUtils.SpeedupFactor);
            force *= speedupFactor;
        }

        // get ball moving
        GetComponent<Rigidbody2D>().AddForce(force);
    }

    /// <summary>
    /// Adds the given listener for the BallLost event
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddBallLostListener(UnityAction listener)
    {
        ballLost.AddListener(listener);
    }

    /// <summary>
    /// Adds the given listener for the BallDied event
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddBallDiedListener(UnityAction listener)
    {
        ballDied.AddListener(listener);
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

    /// <summary>
    /// Handles the speedup effect activated event
    /// </summary>
    /// <param name="duration">duration of the speedup effect</param>
    /// <param name="speedupFactor">the speedup factor</param>
    void HandleSpeedupEffectActivatedEvent(float duration, float speedupFactor)
    {
        // speed up ball and run or add time to timer
        if (!speedupTimer.Running)
        {
            StartSpeedupEffect(duration, speedupFactor);
            rb2d.velocity *= speedupFactor;
        }
        else
        {
            speedupTimer.AddTime(duration);
        }
    }

    /// <summary>
    /// Starts the speedup effect
    /// </summary>
    /// <param name="duration">duration of the speedup effect</param>
    /// <param name="speedupFactor">the speedup factor</param>
    void StartSpeedupEffect(float duration, float speedupFactor)
    {
        this.speedupFactor = speedupFactor;
        speedupTimer.Duration = duration;
        speedupTimer.Run();
    }

    /// <summary>
    /// Start the ball moving when the move timer finishes
    /// </summary>
    void HandleMoveTimerFinished()
    {
        moveTimer.Stop();
        StartMoving();
    }

    /// <summary>
    /// Destroy ball when death timer finishes
    /// </summary>
    void HandleDeathTimerFinished()
    {
        // invoke event and destroy self
        ballDied.Invoke();
        Destroy(gameObject);
    }

    /// <summary>
    /// Returns ball to normal speed when speedup effect finishes
    /// </summary>
    void HandleSpeedupTimerFinished()
    {
        speedupTimer.Stop();
        rb2d.velocity *= 1 / speedupFactor;
    }
}
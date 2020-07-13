using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Ball script
/// </summary>
public class Ball : MonoBehaviour
{
    static float BallImpulseForce = ConfigurationUtils.BallImpulseForce;
    float ballXVelocity, ballYVelocity;
    float BallVelocityVector;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
	    rb2d = GetComponent<Rigidbody2D>();
        /*
	    float angle = 20;
	    Vector2 direction = new Vector2(
		    Mathf.Cos(angle), Mathf.Sin(angle));
	    GetComponent<Rigidbody2D>().AddForce(
		    direction * BallImpulseForce,
		    ForceMode2D.Impulse);
        */
        GetComponent<Rigidbody2D>().AddForce(
	        Vector2.down * BallImpulseForce,
	        ForceMode2D.Impulse);
    }

    public void SetDirection(Vector2 direction)
    {
	    ballXVelocity = rb2d.velocity.x; ballYVelocity = rb2d.velocity.y;
	    BallVelocityVector = Mathf.Sqrt(Mathf.Pow(ballXVelocity, 2) + Mathf.Pow(ballYVelocity, 2));
	    rb2d.velocity = new Vector2(BallVelocityVector * direction.x, BallVelocityVector * direction.y);
    }
}

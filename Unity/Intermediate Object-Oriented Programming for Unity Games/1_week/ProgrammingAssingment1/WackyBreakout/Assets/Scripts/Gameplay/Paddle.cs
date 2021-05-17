using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;

/// <summary>
/// Script for Paddle
/// </summary>
public class Paddle : MonoBehaviour
{
	private Rigidbody2D rb2d;
	private float paddleMoveUnitsPerSecond = ConfigurationUtils.PaddleMoveUnitsPerSecond;
	private float horizontalInput;
	private float halfWidthOfTheCollider;
	private float halfHeightOfTheCollider;
	private float yPos;
	private static float BounceAngleHalfRange = 60f * Mathf.Deg2Rad;

	// Start is called before the first frame update
	void Start()
    {
	    rb2d = GetComponent<Rigidbody2D>();
	    halfWidthOfTheCollider = gameObject.GetComponent<BoxCollider2D>().size.x / 2;
		halfHeightOfTheCollider = gameObject.GetComponent<BoxCollider2D>().size.y / 2;
		yPos = transform.position.y;
    }

    void FixedUpdate()
    {
	    float possibleX = transform.position.x + paddleMoveUnitsPerSecond * horizontalInput;
	    float returnX = CalculateClampedX(possibleX);
	    Vector2 newPosition = new Vector2(returnX, yPos);
	    rb2d.MovePosition(newPosition);
    }

    /// <summary>
    /// Detects collision with a ball to aim the ball
    /// </summary>
    /// <param name="coll">collision info</param>
    void OnCollisionEnter2D(Collision2D coll)
    {
	    bool IsTop = CheckTop(coll);
		if (coll.gameObject.CompareTag("Ball") && IsTop)
	    {
		    // calculate new ball direction
			float ballOffsetFromPaddleCenter = transform.position.x -
		                                       coll.transform.position.x;
		    float normalizedBallOffset = ballOffsetFromPaddleCenter /
		                                 halfWidthOfTheCollider;
		    float angleOffset = normalizedBallOffset * BounceAngleHalfRange;
		    float angle = Mathf.PI / 2 + angleOffset;
		    Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));

		    // tell ball to set direction to new direction
			Ball ballScript = coll.gameObject.GetComponent<Ball>();
		    ballScript.SetDirection(direction);
	    }
    }

    private bool CheckTop(Collision2D coll)
    {
	    float collisionY = coll.GetContact(0).point.y;
		float topY = transform.position.y + halfHeightOfTheCollider;
		if (collisionY <= topY + 0.05 && collisionY >= topY - 0.05)
		{
			return false;
		}
		else
		{
			return true;
		}
    }

    public float CalculateClampedX(float x)
    {
		if (x - halfWidthOfTheCollider < ScreenUtils.ScreenLeft ||
			x + halfWidthOfTheCollider > ScreenUtils.ScreenRight)
		{
			return transform.position.x;
		}
		else
		{
			return x;
		}
    }

    // Update is called once per frame
    void Update()
    {
	    horizontalInput = Input.GetAxis("Horizontal") * paddleMoveUnitsPerSecond;
    }
}

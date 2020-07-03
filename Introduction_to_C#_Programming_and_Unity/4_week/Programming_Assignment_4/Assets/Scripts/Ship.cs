using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// script for controlling our Ship
/// </summary>
public class Ship : MonoBehaviour
{
    //rigidbody of ship
    Rigidbody2D rb;
    Vector2 thrustDirection = new Vector2(1,0);
    const int ThrustForce = 5;
    CircleCollider2D circleCollider;
    float radius;
    const float RotateDegreesPerSecond = 60;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();
        radius = circleCollider.radius;
    }

    /// <summary>
    /// using this for moving object
    /// </summary>
    private void FixedUpdate()
    {
        float thrustInput = Input.GetAxis("Thrust");
        if (thrustInput != 0)
        {
            rb.AddForce(ThrustForce * thrustDirection, ForceMode2D.Force);
            //thrustDirection.x += ThrustForce * thrustInput * Time.deltaTime;
        }
    }

    /// <summary>
    /// when our ship isn't in camera view
    /// </summary>
    private void OnBecameInvisible()
    {
        Vector2 position = transform.position;
        if (position.x - radius < ScreenUtils.ScreenLeft)
        {
            position.x = ScreenUtils.ScreenRight;
        }
        else if (position.x + radius > ScreenUtils.ScreenRight)
        {
            position.x = ScreenUtils.ScreenLeft;
        }
        if (position.y - radius < ScreenUtils.ScreenBottom)
        {
            position.y = ScreenUtils.ScreenTop;
        }
        else if (position.y + radius > ScreenUtils.ScreenTop)
        {
            position.y = ScreenUtils.ScreenBottom;
        }
        transform.position = position;
    }

    /// <summary>
    ///  Update is called once per frame
    /// </summary>
    void Update()
    {
        float rotationInput = Input.GetAxis("Rotate");

        // calculate rotation amount and apply rotation
        float rotationAmount = RotateDegreesPerSecond * Time.deltaTime;
        if (rotationInput < 0)
        {
            rotationAmount *= -1;
            transform.Rotate(Vector3.forward, rotationAmount);
        }
        else if (rotationInput > 0)
        {
            rotationAmount *= 1;
            transform.Rotate(Vector3.forward, rotationAmount);
        }
        Vector3 angle = transform.eulerAngles;
        float rad = angle.z * Mathf.Deg2Rad;
        thrustDirection = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
    }
}

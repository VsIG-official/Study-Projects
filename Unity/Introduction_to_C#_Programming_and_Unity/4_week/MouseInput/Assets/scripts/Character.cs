using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A character
/// </summary>
public class Character : MonoBehaviour
{
    float colliderHalfWidth;
    float colliderHalfHeight;

    //movement support
    const float MoveUnitsPerSecond = 10;

    private void Start()
    {
        BoxCollider2D collider = GetComponent<BoxCollider2D>();
        colliderHalfWidth = collider.size.x / 2;
        colliderHalfHeight = collider.size.y / 2;
    }

    void Update()
    {
        // convert mouse position to world position
        //Vector3 position = Input.mousePosition;
        //position.z = -Camera.main.transform.position.z;
        //position = Camera.main.ScreenToWorldPoint(position);

        //move based on input
        Vector3 position = transform.position;
        float horInput = Input.GetAxis("Horizontal");
        if (horInput != 0)
        {
            position.x += horInput * MoveUnitsPerSecond * Time.deltaTime;
        }

        float verInput = Input.GetAxis("Vertical");
        if (verInput != 0)
        {
            position.y += verInput * MoveUnitsPerSecond * Time.deltaTime;
        }

        // move to mouse position
        transform.position = position;
        ClampInScreen();
    }

    void ClampInScreen()
    {
        // clamp position as necessary
        Vector3 position = transform.position;
        if (position.x - colliderHalfWidth < ScreenUtils.ScreenLeft)
        {
            position.x = ScreenUtils.ScreenLeft + colliderHalfWidth;
        }
        else if (position.x + colliderHalfWidth > ScreenUtils.ScreenRight)
        {
            position.x = ScreenUtils.ScreenRight - colliderHalfWidth;
        }
        if (position.y - colliderHalfHeight < ScreenUtils.ScreenBottom)
        {
            position.y = ScreenUtils.ScreenBottom + colliderHalfHeight;
        }
        else if (position.y + colliderHalfHeight > ScreenUtils.ScreenTop)
        {
            position.y = ScreenUtils.ScreenTop - colliderHalfHeight;
        }

        transform.position = position;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

/// <summary>
/// An asteroid
/// </summary>
public class Asteroid : MonoBehaviour
{
    [SerializeField]
    Sprite asteroidSprite0;
    [SerializeField]
    Sprite asteroidSprite1;
    [SerializeField]
    Sprite asteroidSprite2;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        //Initialize();
        // set random sprite for asteroid
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        int spriteNumber = UnityEngine.Random.Range(0, 3);
        if (spriteNumber < 1)
        {
            spriteRenderer.sprite = asteroidSprite0;
        }
        else if (spriteNumber < 2)
        {
            spriteRenderer.sprite = asteroidSprite1;
        }
        else
        {
            spriteRenderer.sprite = asteroidSprite2;
        }
    }

    public void Initialize(Direction Direction, Vector3 position)
	{
        // apply impulse force to get game object moving
        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;
        float angle = 0;
        this.transform.position = position;

        switch (Direction)
        {
            case Direction.Up:
                angle = Random.Range(75 * Mathf.Deg2Rad, 105 * Mathf.Deg2Rad);
                break;
            case Direction.Down:
                angle = Random.Range(255 * Mathf.Deg2Rad, 285 * Mathf.Deg2Rad);
                break;
            case Direction.Left:
                angle = Random.Range(165 * Mathf.Deg2Rad, 195 * Mathf.Deg2Rad);
                break;
            case Direction.Right:
                angle = Random.Range(-15 * Mathf.Deg2Rad, 15 * Mathf.Deg2Rad);
                break;
        }

        //float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 moveDirection = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = UnityEngine.Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            moveDirection * magnitude,
            ForceMode2D.Impulse);
    }
}

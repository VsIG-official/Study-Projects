using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    private int health = 100;
    SpriteRenderer sprite;

    private void Start()
    {
        // apply impulse force to get game object moving
        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude,
            ForceMode2D.Impulse);
        sprite = GetComponent<SpriteRenderer>();
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
        health -= 10;
        Color color = sprite.color;
        color.a -= 0.1f;
        sprite.color = color;
        if (health <= 0)
		{
            Destroy(gameObject);
		}
	}
}

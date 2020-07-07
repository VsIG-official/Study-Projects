using System.Security.Cryptography;
using UnityEngine;

/// <summary>
/// A Bullet
/// </summary>
public class Bullet : MonoBehaviour
{
	const float bulletLife = 2f;
	Timer timer;

	private void Start()
	{
		timer = gameObject.AddComponent<Timer>();
		timer.Duration = bulletLife;
		timer.Run();
	}

	private void Update()
	{
		if (timer.Finished)
		{
			Destroy(gameObject);
		}
	}

	/// <summary>
	/// Applies the force.
	/// </summary>
	/// <param name="direction">The direction.</param>
	public void ApplyForce(Vector2 direction)
	{
		const float magnitudeForce = 2f;
		Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
		rb2d.AddForce(magnitudeForce * direction, ForceMode2D.Impulse);
	}
}

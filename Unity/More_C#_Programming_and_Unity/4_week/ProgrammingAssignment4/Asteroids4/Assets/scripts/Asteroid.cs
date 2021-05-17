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

	private CircleCollider2D col2d;
	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
		col2d = GetComponent<CircleCollider2D>();
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

	public void StartMoving(float angle)
	{
		const float MinImpulseForce = 0.5f;
		const float MaxImpulseForce = 1.5f;

		Vector2 moveDirection = new Vector2(
			Mathf.Cos(angle), Mathf.Sin(angle));
		float magnitude = UnityEngine.Random.Range(MinImpulseForce, MaxImpulseForce);
		GetComponent<Rigidbody2D>().AddForce(
			moveDirection * magnitude,
			ForceMode2D.Impulse);
	}

	public void Initialize(Direction Direction, Vector3 position)
	{
		// apply impulse force to get game object moving
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
		StartMoving(angle);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Bullet")
		{
			AudioManager.Play(AudioClipName.AsteroidHit);
			Destroy(collision.gameObject);

			if (gameObject.transform.localScale.x >= 0.5f)
			{
				Vector3 newSize = gameObject.transform.localScale /= 2;
				float angle = Random.Range(0f, 2f) * Mathf.PI;

				for (int i = 0; i < 2; i++)
				{
					GameObject asteroidClone = Instantiate(gameObject, transform.position, transform.rotation);
					asteroidClone.GetComponent<Asteroid>().StartMoving(angle);
					angle = Random.Range(0f, 2f) * Mathf.PI;
				}
			}
			Destroy(this.gameObject);
		}
	}
}

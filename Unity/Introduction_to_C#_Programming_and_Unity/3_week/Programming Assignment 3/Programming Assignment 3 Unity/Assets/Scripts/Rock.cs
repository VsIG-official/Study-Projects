using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// rock object
/// </summary>
public class Rock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /// <summary>
        /// start characteristics
        /// </summary>
        // apply impulse force to get game object moving
        const float MinImpulseForce = 0.5f;
        const float MaxImpulseForce = 1f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude,
            ForceMode2D.Impulse);
    }

    //when rock is invisible
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

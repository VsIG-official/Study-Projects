using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear
/// </summary>
public class TeddyBear : MonoBehaviour
{
	/// <summary>
    /// Use this for initialization
    /// </summary>
	void Start()
    {
        // get the teddy bear moving
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(3,0),ForceMode2D.Impulse);
    }

}
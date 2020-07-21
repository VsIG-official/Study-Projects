using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A block
/// </summary>
public class Block : MonoBehaviour
{
	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
		
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		
	}

    /// <summary>
    /// Destroys the block on collision with a ball
    /// </summary>
    /// <param name="coll">Coll.</param>
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
        }
    }
}

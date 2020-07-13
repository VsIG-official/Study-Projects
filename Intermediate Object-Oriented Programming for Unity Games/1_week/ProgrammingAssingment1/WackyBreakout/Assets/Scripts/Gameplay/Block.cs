using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Block script
/// </summary>
public class Block : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D coll)
    {
	    if (coll.gameObject.CompareTag("Ball"))
	    {
            Destroy(gameObject);
	    }
    }
}

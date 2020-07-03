using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Processes mouse button inputs
/// </summary>
public class MouseButtonProcessor : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;
    [SerializeField]
    GameObject prefabTeddyBear;

    // first frame input support
    bool spawnInputOnPreviousFrame = false;
	bool explodeInputOnPreviousFrame = false;

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        // spawn teddy bear as appropriate
		if (Input.GetAxis("SpawnTeddyBear") > 0)
		{
			if (!spawnInputOnPreviousFrame)
			{
				spawnInputOnPreviousFrame = true;
				Vector3 mousePos = Input.mousePosition;
				mousePos.z = -Camera.main.transform.position.z;
				mousePos = Camera.main.ScreenToWorldPoint(mousePos);
				Instantiate(prefabTeddyBear, mousePos, Quaternion.identity);
			}
		}
		else
		{
			spawnInputOnPreviousFrame = false;
		}
		// explode teddy bear as appropriate
		if (Input.GetAxis("ExplodeTeddyBear") > 0)
		{
			if(!explodeInputOnPreviousFrame && GameObject.FindGameObjectWithTag("TeddyBear"))
			{
				GameObject teddyBear = GameObject.FindWithTag("TeddyBear");
				explodeInputOnPreviousFrame = true;
				Destroy(GameObject.FindGameObjectWithTag("TeddyBear"));
				Instantiate(prefabExplosion, teddyBear.transform.position, Quaternion.identity);
			}
		}
		else
		{
			explodeInputOnPreviousFrame = false;
		}
	}
}

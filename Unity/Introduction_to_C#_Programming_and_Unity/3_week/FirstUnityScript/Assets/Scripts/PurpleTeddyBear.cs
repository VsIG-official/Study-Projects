using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// make teddy bear larger
/// </summary>
public class PurpleTeddyBear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // quadruple  width and  height
        Vector3 newScale = transform.localScale;

        newScale.x = 3;

        transform.localScale = newScale;
    }
}

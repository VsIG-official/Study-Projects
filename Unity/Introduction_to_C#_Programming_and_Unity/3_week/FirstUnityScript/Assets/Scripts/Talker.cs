using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// makes the game object talk
/// </summary>
public class Talker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = transform.position;
        position.x = 1;
        //say something
        Debug.Log("I`m the best game object ever");
    }
}

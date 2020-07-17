using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is child class of the Ball
/// </summary>
public class GreenBall : Ball
{

    // Start is called before the first frame update
    protected override void Start()
    {
	    impulseVector = new Vector2(0, 5);
        base.Start();
    }

    protected override void PrintMessage()
    {
	    print("I'm a green ball");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A green ball
/// </summary>
public class GreenBall : Ball
{
	/// <summary>
	/// Use this for initialization
	/// </summary>
	override protected void Start()
	{
        impulseVector.x = 0;
        impulseVector.y = 5;
        base.Start();
	}

    /// <summary>
    /// Prints a message
    /// </summary>
    protected override void PrintMessage()
    {
        print("I'm a green ball");
    }
}

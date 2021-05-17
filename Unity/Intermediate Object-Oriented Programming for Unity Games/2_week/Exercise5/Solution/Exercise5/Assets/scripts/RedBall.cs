using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A red ball
/// </summary>
public class RedBall : Ball
{
    /// <summary>
    /// Prints a message
    /// </summary>
    protected override void PrintMessage()
    {
        print("I'm a red ball");
    }
}

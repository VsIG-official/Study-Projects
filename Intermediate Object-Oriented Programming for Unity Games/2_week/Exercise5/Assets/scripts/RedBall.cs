using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is child class of the Ball
/// </summary>
public class RedBall : Ball
{
	protected override void PrintMessage()
	{
		print("I'm a red ball");
	}
}

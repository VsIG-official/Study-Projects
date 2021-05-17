using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateProjectile : Projectile
{
	/// <summary>
	/// Use this for initialization
	/// </summary>
	override protected void Start()
	{
		impulseForce.x = 3f;
		base.Start();
	}
}

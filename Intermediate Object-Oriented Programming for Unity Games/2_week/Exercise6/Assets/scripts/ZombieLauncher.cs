using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieLauncher : Launcher
{
	// Start is called before the first frame update
	void Start()
	{
		cooldownSeconds = 2f;
		base.Start();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateLauncher : Launcher
{
    // Start is called before the first frame update
    void Start()
    {
	    cooldownSeconds = 1f;
	    base.Start();
    }
}

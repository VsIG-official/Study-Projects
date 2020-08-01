using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A bonus block
/// </summary>
public class BonusBlock : Block
{
	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        // set points
        points = ConfigurationUtils.BonusBlockPoints;
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		
	}
}

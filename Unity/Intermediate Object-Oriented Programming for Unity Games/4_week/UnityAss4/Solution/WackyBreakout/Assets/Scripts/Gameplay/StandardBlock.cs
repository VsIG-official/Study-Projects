using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A standard block
/// </summary>
public class StandardBlock : Block
{
    [SerializeField]
    Sprite sprite0;
    [SerializeField]
    Sprite sprite1;
    [SerializeField]
    Sprite sprite2;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	override protected void Start()
	{
        base.Start();

        // set points and random sprite
        points = ConfigurationUtils.StandardBlockPoints;
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        int spriteNumber = Random.Range(0, 3);
        if (spriteNumber == 0)
        {
            spriteRenderer.sprite = sprite0;
        }
        else if (spriteNumber == 1)
        {
            spriteRenderer.sprite = sprite1;
        }
        else
        {
            spriteRenderer.sprite = sprite2;
        }
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		
	}
}

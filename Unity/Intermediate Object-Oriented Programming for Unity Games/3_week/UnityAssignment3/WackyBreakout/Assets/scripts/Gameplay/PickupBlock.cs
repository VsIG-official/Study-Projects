using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// A pickup block
/// </summary>
public class PickupBlock : Block
{
    [SerializeField]
    Sprite freezerSprite;
    [SerializeField]
    Sprite speedupSprite;

    PickupEffect effect;

    private int effectDuration;
    private FreezerEffectActivated freezerEffectActivated;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
	{
		points = ConfigurationUtils.PickupBlockPoints;
	}

    virtual protected void OnCollisionEnter2D(Collision2D coll)
    {
	    if (coll.gameObject.CompareTag("Ball"))
	    {
		    if (effect == PickupEffect.Freezer)
		    {
			    freezerEffectActivated.Invoke(effectDuration);
            }
        }
    }

    /// <summary>
    /// Sets the effect for the pickup
    /// </summary>
    /// <value>pickup effect</value>
    public PickupEffect Effect
    {
        set
        {
            effect = value;

            // set sprite
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            if (effect == PickupEffect.Freezer)
            {
                spriteRenderer.sprite = freezerSprite;
                effectDuration = ConfigurationUtils.FreezerEffectDuration;
                freezerEffectActivated = new FreezerEffectActivated();
                EventManager.AddFreezerEffectInvoker(this);
            }
            else
            {
                spriteRenderer.sprite = speedupSprite;
            }
        }
    }

	public void AddFreezerEffectListener(UnityAction<float> listener)
	{
		freezerEffectActivated.AddListener(listener);
    }
}

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

    // effect-specific values
    PickupEffect effect;
    float duration;
    FreezerEffectActivated freezerEffectActivated;
    float speedupFactor;
    SpeedupEffectActivated speedupEffectActivated;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    override protected void Start()
    {
        base.Start();

        // set points
        points = ConfigurationUtils.PickupBlockPoints;
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {

    }

    /// <summary>
    /// Invokes the pickup effect event and destroys the block on collision with a ball
    /// </summary>
    /// <param name="coll">Coll.</param>
    override protected void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ball"))
        {
            if (effect == PickupEffect.Freezer)
            {
                AudioManager.Play(AudioClipName.FreezerEffectActivated);
                freezerEffectActivated.Invoke(duration);
            }
            else if (effect == PickupEffect.Speedup)
            {
                AudioManager.Play(AudioClipName.SpeedupEffectActivated);
                speedupEffectActivated.Invoke(duration, speedupFactor);
            }
            base.OnCollisionEnter2D(coll);
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

            // set sprite and duration
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            if (effect == PickupEffect.Freezer)
            {
                spriteRenderer.sprite = freezerSprite;
                duration = ConfigurationUtils.FreezerSeconds;
                freezerEffectActivated = new FreezerEffectActivated();
                EventManager.AddFreezerEffectInvoker(this);
            }
            else
            {
                spriteRenderer.sprite = speedupSprite;
                duration = ConfigurationUtils.SpeedupSeconds;
                speedupFactor = ConfigurationUtils.SpeedupFactor;
                speedupEffectActivated = new SpeedupEffectActivated();
                EventManager.AddSpeedupEffectInvoker(this);
            }
        }
    }

    /// <summary>
    /// Adds the given listener to the freezer effect activated event
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddFreezerEffectListener(UnityAction<float> listener)
    {
        freezerEffectActivated.AddListener(listener);
    }

    /// <summary>
    /// Adds the given listener to the speedup effect activated event
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddSpeedupEffectListener(UnityAction<float, float> listener)
    {
        speedupEffectActivated.AddListener(listener);
    }
}

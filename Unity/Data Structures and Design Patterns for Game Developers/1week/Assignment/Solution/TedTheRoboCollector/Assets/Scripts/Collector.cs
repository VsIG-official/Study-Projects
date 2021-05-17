using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A collecting game object
/// </summary>
public class Collector : MonoBehaviour
{
	#region Fields

    // targeting support
    SortedList<Target> targets = new SortedList<Target>();
    Target targetPickup = null;

    // movement support
	const float BaseImpulseForceMagnitude = 2.0f;
    const float ImpulseForceIncrement = 0.3f;

	// saved for efficiency
    Rigidbody2D rb2d;

    #endregion

    #region Methods

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
		// center collector in screen
		Vector3 position = transform.position;
		position.x = 0;
		position.y = 0;
		position.z = 0;
		transform.position = position;

		// save reference for efficiency
		rb2d = GetComponent<Rigidbody2D>();

        // add as listener for pickup spawned event
        EventManager.AddListener(HandlePickupSpawnedEvent);
	}

    /// <summary>
    /// Called when another object is within a trigger collider
    /// attached to this object
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerStay2D(Collider2D other)
    {
        // only respond if the collision is with the target pickup
        if (other.gameObject == targetPickup.GameObject)
        {
            // remove collected pickup from list of targets and game
            int targetPickupIndex = targets.IndexOf(targetPickup);
            GameObject deadTarget = targets[targetPickupIndex].GameObject;
            targets.RemoveAt(targetPickupIndex);
            Destroy(deadTarget);

            // go to next target if there is one
            rb2d.velocity = Vector2.zero;
            if (targets.Count > 0)
            {
                for (int i = 0; i < targets.Count; i++)
                {
                    targets[i].UpdateDistance(transform.position);
                }
                targets.Sort();
                SetTarget(targets[targets.Count - 1]);
            }
            else
            {
                targetPickup = null;
            }
		}
	}

    /// <summary>
    /// Handles the pickup spawned event
    /// </summary>
    /// <param name="pickup">pickup that was spawned</param>
    void HandlePickupSpawnedEvent(GameObject pickup)
    {
        // add new pickup to list of targets
        targets.Add(new Target(pickup, transform.position));

        // change target as appropriate
        float targetPickupDistance;
        if (targetPickup != null)
        {
            targetPickupDistance = Vector3.Distance(
                targetPickup.GameObject.transform.position, transform.position);
        }
        else
        {
            targetPickupDistance = float.MaxValue;
        }
        if (targets[targets.Count - 1].Distance < targetPickupDistance)
        {
            SetTarget(targets[targets.Count - 1]);
        }
    }

    /// <summary>
    /// Sets the target pickup to the provided pickup
    /// </summary>
    /// <param name="pickup">Pickup.</param>
    void SetTarget(Target pickup)
    {
        targetPickup = pickup;
        GoToTargetPickup();
    }

    /// <summary>
    /// Starts the collector moving toward the target pickup
    /// </summary>
    void GoToTargetPickup()
    {
        // calculate direction to target pickup and start moving toward it
        Vector2 direction = new Vector2(
            targetPickup.GameObject.transform.position.x - transform.position.x,
            targetPickup.GameObject.transform.position.y - transform.position.y);
        direction.Normalize();
        rb2d.velocity = Vector2.zero;
        float impulseForce = BaseImpulseForceMagnitude +
            ImpulseForceIncrement * targets.Count;
        rb2d.AddForce(direction * impulseForce, 
            ForceMode2D.Impulse);
    }

	#endregion
}

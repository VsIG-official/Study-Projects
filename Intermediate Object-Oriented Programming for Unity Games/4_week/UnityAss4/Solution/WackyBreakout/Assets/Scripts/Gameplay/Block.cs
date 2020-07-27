using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// A block
/// </summary>
public class Block : MonoBehaviour
{
    // scoring support
    protected int points;
    PointsAdded pointsAdded;

    // destruction support
    BlockDestroyed blockDestroyed;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    virtual protected void Start()
    {
        // scoring support
        pointsAdded = new PointsAdded();
        EventManager.AddPointsAddedInvoker(this);

        // destruction support
        blockDestroyed = new BlockDestroyed();
        EventManager.AddBlockDestroyedInvoker(this);
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {

    }

    /// <summary>
    /// Destroys the block on collision with a ball
    /// </summary>
    /// <param name="coll">Coll.</param>
    virtual protected void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ball"))
        {
            pointsAdded.Invoke(points);
            blockDestroyed.Invoke();
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Adds the given listener for the PointsAdded event
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddPointsAddedListener(UnityAction<int> listener)
    {
        pointsAdded.AddListener(listener);
    }

    /// <summary>
    /// Adds the given listener for the BlockDestroyed event
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddBlockDestroyedListener(UnityAction listener)
    {
        blockDestroyed.AddListener(listener);
    }
}

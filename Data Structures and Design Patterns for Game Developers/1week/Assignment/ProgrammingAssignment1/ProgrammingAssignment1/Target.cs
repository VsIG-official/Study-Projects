﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A target for the collector
/// </summary>
public class Target : IComparable
{
    #region Fields

    GameObject gameObject;
    float distance;

    #endregion

    #region Constructors

    /// <summary>
    /// Constructs a target with the given game object and the
    /// current position of the collector
    /// </summary>
    /// <param name="gameObject">target game object</param>
    /// <param name="position">collector position</param>
    public Target(GameObject gameObject, Vector3 position)
    {
        this.gameObject = gameObject;
        UpdateDistance(position);
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets the target game object
    /// </summary>
    /// <value>target game object</value>
    public GameObject GameObject
    {
        get { return gameObject; }
    }
	
    /// <summary>
    /// Gets the distance for the target
    /// </summary>
    /// <value>distance</value>
    public float Distance
    {
        get { return distance; }
    }
	
    #endregion

    #region Public methods

    /// <summary>
    /// Updates the distance from the target game object to
    /// the given position
    /// </summary>
    /// <param name="position">position for distance calculation</param>
    public void UpdateDistance(Vector3 position)
    {
        distance = Vector3.Distance(gameObject.transform.position,
            position);
    }

    /// <summary>
    /// Compares the current instance with another object of the same type 
    /// and returns an integer that indicates whether the current instance 
    /// precedes, follows, or occurs in the same position in the sort order
    /// as the other object.
    /// </summary>
    /// <returns>relative order of this instance and object</returns>
    /// <param name="obj">object to compare to</param>
    public int CompareTo(object obj)
    {
        // replace the code below with your implementation
        return 0;
    }
	
    /// <summary>
    /// Converts the target to a string
    /// </summary>
    /// <returns>the string for the target</returns>
    public override string ToString()
    {
        return distance.ToString();
    }
	
    #endregion
}

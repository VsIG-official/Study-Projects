using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A pirate projectile
/// </summary>
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

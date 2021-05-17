﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A zombie projectile
/// </summary>
public class ZombieProjectile : Projectile
{
    /// <summary>
    /// Use this for initialization
    /// </summary>
    override protected void Start()
    {
        impulseForce.x = 9f;
        base.Start();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("coll");
        ProjectileHitable hit;
        if (other.gameObject.TryGetComponent<ProjectileHitable>(out hit))
        {
            hit.Hit();
        }
        Destroy(gameObject);
    }


}

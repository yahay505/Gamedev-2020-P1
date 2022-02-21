using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject projectile;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootRanged();
        }
    }

    void ShootRanged()
    {
        var mousepoint=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var delta = mousepoint-transform.position;
        delta.z = 0;
        var normalize = Vector3.Normalize(delta);
        var spawnedProjectile=Instantiate(projectile,transform.position,transform.rotation);
        spawnedProjectile.GetComponent<Rigidbody2D>().AddForce(normalize*1000,ForceMode2D.Force);
    }
    // void AttackMelee
}

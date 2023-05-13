using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectilecontroller : MonoBehaviour
{
    public Vector3 launchDirection;
    public GameObject Projectile;

    public void FireProjectile()
    {
        GameObject temp = (GameObject)Instantiate(Projectile);

        temp.transform.position = this.gameObject.transform.position;
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 launchDirection;

    public enum BULLETTYPE
    {
        PLAYER,
        ENEMY
    }

    public BULLETTYPE bulletType = BULLETTYPE.PLAYER;

    private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;
        transform.Translate(launchDirection * moveAmount);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.tag == "wall")
        {
            GameObject temp = this.gameObject;
            Destroy(temp);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "wall")             
        {
            GameObject temp = this.gameObject;                  
            Destroy(temp);                                      
        }

        if (other.gameObject.tag == "Monster" && bulletType == BULLETTYPE.PLAYER)
        {
            other.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            other.gameObject.transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1);
            GameObject temp = this.gameObject;
            Destroy(temp);
        }
        if(other.gameObject.tag == "Player" && bulletType == BULLETTYPE.ENEMY)
        {
            other.gameObject.GetComponent<PlayerController>();
        }
    }
        
}
    
using UnityEngine;
using System.Collections;           
public class respawnDie : MonoBehaviour
{
    Vector2  startpos;
    void Start()
    {
        startpos = transform.position;
    }

    
   private void OnTriggerEnter2D (Collider2D collision)
    {
         if (collision.CompareTag("morte"))
         {
             Die();
         }
    }

    void Die()
    {
       respawn();
    }

    void respawn()
    {
        //move the player to the start position 
        transform.position = startpos;
    }
}

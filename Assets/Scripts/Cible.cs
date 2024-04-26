using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cible : MonoBehaviour
{
    public int scoreValue = 1;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject); // Détruit la cible lorsqu'elle est touchée par un projectile

        }

    }
   
}

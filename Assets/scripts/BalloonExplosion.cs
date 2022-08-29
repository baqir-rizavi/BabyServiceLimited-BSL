using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonExplosion : MonoBehaviour
{
    [SerializeField] Transform particles;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(particles, other.GetContact(0).point, Quaternion.identity);
            Destroy(other.gameObject);
            // game over UI displayed
        }
    }
}

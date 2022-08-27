using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    [SerializeField] private float speed = 1f;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);

            Destroy(gameObject,0.3f);
        }
    }
}

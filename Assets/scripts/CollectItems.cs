using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    [SerializeField] GameObject particles;
    AudioManager aux;

    void Awake()
    {
        GameObject sm = GameObject.Find("SoundManager");
        if (sm != null)
        {
            aux = sm.GetComponent<AudioManager>();
        }

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            aux.Play("collect_items");
            GameObject p = Instantiate(particles, other.GetContact(0).point, Quaternion.identity) as GameObject;
            Destroy(p, 1f);
            Destroy(gameObject);
        }
    }
}

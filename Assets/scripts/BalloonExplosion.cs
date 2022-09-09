using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonExplosion : MonoBehaviour
{
    [SerializeField] Transform particles;
    GameObject LevelManager;

    GameOver instance;

    void Awake()
    {
        LevelManager = GameObject.Find("LevelManager");
        if (LevelManager == null)
        {
            Debug.LogError("set a LevelManager in the scene");
        }
        instance = LevelManager.GetComponent<GameOver>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(particles, other.GetContact(0).point, Quaternion.identity);
            Destroy(other.gameObject);

            instance.EndGameInSeconds(1f);
            
        }
    }
}

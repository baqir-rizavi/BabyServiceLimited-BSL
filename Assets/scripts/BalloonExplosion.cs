using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

            SceneManager.LoadScene("Gameover");

            StartCoroutine(GameOver());
            
        }
    }

    private IEnumerator GameOver()
    {
        yield return new WaitForSeconds(3.0f);

        SceneManager.LoadScene("Gameover");
    }
}

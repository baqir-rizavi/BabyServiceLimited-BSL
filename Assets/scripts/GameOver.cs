using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void EndGameInSeconds(float sec)
    {
        StartCoroutine(EndGameRoutine(sec));
    }
    
    IEnumerator EndGameRoutine(float sec)
    {
        yield return new WaitForSeconds(sec);
        SceneManager.LoadScene("Gameover");
    }
}

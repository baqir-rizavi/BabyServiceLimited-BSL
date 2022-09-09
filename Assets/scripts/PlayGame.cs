using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public void LoadCurrentLevel()
    {
        SceneManager.LoadScene(GameManager.GetInstance().GetCurrentLevel());
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("LEVEL1");
    }
}
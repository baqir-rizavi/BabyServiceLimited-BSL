using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    [SerializeField] AudioManager aux;

    public void LoadCurrentLevel()
    {
        aux.Play("button_click");
        SceneManager.LoadScene(GameManager.GetInstance().GetCurrentLevel());
    }

    public void LoadNextLevel()
    {
        aux.Play("button_click");
        SceneManager.LoadScene(GameManager.GetInstance().GetNextLevel());
    }

    public void LoadLevel1()
    {
        aux.Play("button_click");
        SceneManager.LoadScene("LEVEL1");
    }

    public void doExitGame()
    {
        aux.Play("button_click");
        Application.Quit();
    }

    public void LoadHome()
    {
        aux.Play("button_click");
        SceneManager.LoadScene("MainMenu");
    }
}
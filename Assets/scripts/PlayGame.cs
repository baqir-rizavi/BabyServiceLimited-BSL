using UnityEngine;
using UnityEditor.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        EditorSceneManager.LoadScene(sceneName);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class GoToHome : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        EditorSceneManager.LoadScene(sceneName);
    }
}

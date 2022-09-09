using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level5Initializer : MonoBehaviour
{
    private void Awake()
    {
        GameManager.GetInstance().SetCurrentLevel("LEVEL5"); 
        GameManager.GetInstance().SetNextLevel("MainMenu"); 
    }
}

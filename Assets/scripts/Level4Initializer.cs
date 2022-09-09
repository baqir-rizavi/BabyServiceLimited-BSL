using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4Initializer : MonoBehaviour
{
    private void Awake()
    {
        GameManager.GetInstance().SetCurrentLevel("LEVEL4"); 
        GameManager.GetInstance().SetNextLevel("LEVEL5"); 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Initializer : MonoBehaviour
{
    private void Awake()
    {
        GameManager.GetInstance().SetCurrentLevel("LEVEL1"); 
        GameManager.GetInstance().SetNextLevel("LEVEL2"); 
    }
}

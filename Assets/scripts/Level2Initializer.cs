using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Initializer : MonoBehaviour
{
    private void Awake()
    {
        GameManager.GetInstance().SetCurrentLevel("LEVEL2"); 
        GameManager.GetInstance().SetNextLevel("LEVEL3"); 
    }
}

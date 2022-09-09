using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Initializer : MonoBehaviour
{
    private void Awake()
    {
        GameManager.GetInstance().SetCurrentLevel("LEVEL3"); 
        GameManager.GetInstance().SetNextLevel("LEVEL4"); 
    }
}

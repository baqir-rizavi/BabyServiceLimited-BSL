using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Initializer : MonoBehaviour
{
    private void Awake()
    {
        Destroy(GameObject.Find("Canvas"), 2f);
        GameManager.GetInstance().SetCurrentLevel("LEVEL1");
        GameManager.GetInstance().SetNextLevel("LEVEL2"); 
    }
}

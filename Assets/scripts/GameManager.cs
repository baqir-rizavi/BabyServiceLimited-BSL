using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager GM;

    string current_level = "LEVEL1";

    public string GetCurrentLevel()
    {
        return current_level;
    }

    public static GameManager GetInstance()
    {
        return GM;
    }
    
    // for Level initializers only
    public void SetCurrentLevel(string curr_level)
    {
        current_level = curr_level;
    }

    private void Awake()
    {
        if (GM == null)
        {
            GM = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


}

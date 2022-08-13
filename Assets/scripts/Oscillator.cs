using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float amplitude = 1f;
    [SerializeField] string axis = "x";
   

    // Update is called once per frame
    void Update()
    {
        if (axis == "x")
        {  
            transform.position = new Vector3 (amplitude * Mathf.Sin(Time.time * speed) + transform.position.x,transform.position.y,transform.position.z);
        }
        else if (axis == "y")
        {
            transform.position = new Vector3 (transform.position.x,amplitude * Mathf.Sin(Time.time * speed) + transform.position.y,transform.position.z);
        }
        else if (axis == "z")
        {
            transform.position = new Vector3 (transform.position.x,transform.position.y,amplitude * Mathf.Sin(Time.time * speed) + transform.position.z);
        }
        else
        {
            Debug.Log("Abay axis sai do!!");
        }
    }
}

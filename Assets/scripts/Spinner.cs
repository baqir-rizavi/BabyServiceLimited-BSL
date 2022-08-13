using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] string axis = "x";
    [SerializeField] float speed = 1f;

   
    // Update is called once per frame
    void Update()
    {
        if (axis == "x")
        {  
            transform.Rotate(Vector3.right*speed*Time.deltaTime);
        }
        else if (axis == "y")
        {
            transform.Rotate(Vector3.up*speed*Time.deltaTime);
        }
        else if (axis == "z")
        {
            transform.Rotate(Vector3.forward*speed*Time.deltaTime);
        }
        else
        {
            Debug.Log("Abay axis sai do!!");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] Axis axis = Axis.x;
    [SerializeField] float speed = 1f;
    [SerializeField] Space relativeTo = Space.World;

   
    // Update is called once per frame
    void Update()
    {
        if (axis == Axis.x)
        {  
            transform.Rotate(Vector3.right*speed*Time.deltaTime, relativeTo);
        }
        else if (axis == Axis.y)
        {
            transform.Rotate(Vector3.up*speed*Time.deltaTime, relativeTo);
        }
        else if (axis == Axis.z)
        {
            transform.Rotate(Vector3.forward*speed*Time.deltaTime, relativeTo);
        }
        else
        {
            Debug.Log("Abay axis sai do!!");
        }
    }
}

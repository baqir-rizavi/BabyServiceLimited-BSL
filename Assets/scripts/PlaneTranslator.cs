using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTranslator : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    [SerializeField]  string direction = "left";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == "left")
        {
            if (transform.position.z <= 20f)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
            }
        }
        else if (direction == "right")
        {
            if (transform.position.z <= 20f)
            {
                transform.Translate(-Vector3.left * speed * Time.deltaTime, Space.World);
            }
        }
        
    }
}
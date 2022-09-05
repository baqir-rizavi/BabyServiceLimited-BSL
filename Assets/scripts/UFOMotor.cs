using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOMotor : MonoBehaviour
{

    [SerializeField] Transform target;
    [SerializeField] float smoothness;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 nextPos = new Vector3(target.position.x, transform.position.y, target.position.z);
        transform.position = Vector3.Lerp(transform.position, nextPos, 1f/smoothness * Time.deltaTime);
    }
}

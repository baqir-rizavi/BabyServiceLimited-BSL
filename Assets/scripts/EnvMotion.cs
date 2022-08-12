using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvMotion : MonoBehaviour
{
    [SerializeField] float speed = 20f;

    void Update()
    {
        transform.Translate(-Vector3.forward * speed * Time.deltaTime, Space.World);   
    }
}

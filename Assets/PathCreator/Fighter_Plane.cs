using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Fighter_Plane : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 100;
    float distanceTravelled;

    // Update is called once per frame
    void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
        //transform.rotation = Quaternion.Euler(-75, -185, 5);

    }
}

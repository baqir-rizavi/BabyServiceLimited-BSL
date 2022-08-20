using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motions : MonoBehaviour
{
    [SerializeField] Path path;
    [SerializeField] float scale = 1;
    [SerializeField] float position = -5f;
    [SerializeField] string face = "left";

    public Transform Target;

    public float RotationSpeed = 1;

    public float CircleRadius = 1;

    public float ElevationOffset = 0;

    private Vector3 positionOffset;
    private float angle;

    private void LateUpdate()
    {
        if (path == Path.circular)
        {
            if (face == "right")
            {
                positionOffset.Set(
                Mathf.Sin(angle) * CircleRadius,
                ElevationOffset,
                Mathf.Cos(angle) * CircleRadius
            );
            }

            else if (face =="left")
            {
                positionOffset.Set(
               Mathf.Cos(angle) * CircleRadius,
               ElevationOffset,
               Mathf.Sin(angle) * CircleRadius
           );
            }

            transform.position = Target.position + positionOffset;
            angle += Time.deltaTime * RotationSpeed;
        }
    }

    private void Start()
    {

        if (path == Path.u)
        {
            if (face == "right")
            {
                position += 0.075f;
            }
            else if (face == "left")
            {
                position -= 0.075f;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (path == Path.u)
        {
            if (transform.position.z <= 11f)
            {
                if (face == "right")
                {
                    position += 0.075f;
                }
                else if (face == "left")
                {
                    position -= 0.075f;
                }

                transform.position = new Vector3(position, scale * Umotion(position), transform.position.z);
            }
           
        }
    }

    float Umotion(float x)
    {
        return Mathf.Abs(x);
    }
}
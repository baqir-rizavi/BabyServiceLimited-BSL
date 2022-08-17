using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBalloonMov : MonoBehaviour
{
    [SerializeField] float start;
    [SerializeField] Path path;
    [SerializeField] float scale = 1;
    [SerializeField] float intercept = 1;
    private float temp;
    private bool isEnd = false;

    private void Start()
    {

        if (path == Path.u)
        {
            temp = start;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //counter+= 0.04f;
        if (path == Path.u)
        {
            if (start > -temp)
            {
                isEnd = true;
            }

            if (start < temp)
            {
                isEnd = false;
            }

            if (isEnd == false)
            {
                start += 0.04f;
            }
            else if (isEnd == true)
            {
                start -= 0.04f;
            }

            transform.position = new Vector3(start, scale * Mathf.Pow(start, 2) + intercept, transform.position.z);
        }
    }

}

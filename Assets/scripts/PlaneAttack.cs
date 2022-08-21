using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneAttack : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float pathSize = 5f;
    [SerializeField] float baseYPosition = 5f;

    float inputVar = -5f;
    Vector3 newPos;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(speed * Time.time - 20, uAttack(speed * Time.time - 20), transform.position.z), Time.deltaTime);
    }

    float uAttack(float inp)
    {
        return inp * inp * pathSize + baseYPosition;
    }
}

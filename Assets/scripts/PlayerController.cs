using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float sidewaySpeed = 1.5f;
    [SerializeField] float forwardSpeed = 3f;
    [SerializeField] float inverseAcceleration = 1f;

    Touch touch;
    
    void Update()
    {  
        handleTouchMovement();
        boxClampPosition();
    }

    void handleTouchMovement()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                Vector3 next = new Vector3(touch.deltaPosition.x * sidewaySpeed, transform.position.y, touch.deltaPosition.y * forwardSpeed);  
                transform.position = Vector3.Lerp(transform.position, next, 1/inverseAcceleration * Time.deltaTime);
            }
        }
    }

    void boxClampPosition(){
        Vector3 pos = transform.position;
                pos.x = Mathf.Clamp(pos.x, -6, 6);
                pos.z = Mathf.Clamp(pos.z, -6, 6);
                transform.position = pos;
    }
}

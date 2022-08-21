using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{

    [SerializeField] float sidewaySpeed = 1.5f;
    [SerializeField] float forwardSpeed = 3f;
    [SerializeField] float inverseAcceleration = 1f;
    
    Animator anim;
    Touch touch;
    static int speedVal = Animator.StringToHash("speed");
    Vector3 nextPos = Vector3.zero;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {  
        handleTouchMovement();
        handleAnimation();
        boxClampPosition();
    }

    void handleTouchMovement()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                nextPos = new Vector3(touch.deltaPosition.x * sidewaySpeed, transform.position.y, touch.deltaPosition.y * forwardSpeed);  
                transform.position = Vector3.Lerp(transform.position, nextPos, 1/inverseAcceleration * Time.deltaTime);
            }
            else
            {
                nextPos = Vector3.zero;
            }
        }
    }

    void handleAnimation()
    {
        anim.SetFloat(speedVal, nextPos.x);
    }

    void boxClampPosition(){
        Vector3 pos = transform.position;
                pos.x = Mathf.Clamp(pos.x, -6, 6);
                pos.z = Mathf.Clamp(pos.z, -6, 10);
                transform.position = pos;
    }
}

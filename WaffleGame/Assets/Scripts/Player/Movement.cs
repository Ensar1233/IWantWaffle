using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float forwardSpeed;
    [SerializeField] private float rightSpeed = 5f;
    private float horizontalSpeed;
    [Header("Controller")]
    public bool touchMov = true;
    public bool keyboardMov;
    
    
    void Update()
    {
        ForwardMovement();
        if (keyboardMov) 
        {
            RightMovement();
            touchMov = false;
        }
        if (touchMov) 
        {
            TouchRightMovement();
            keyboardMov = false;
        }
        Demarcation();

      

    }


    private void ForwardMovement()
    {
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

    }
    private void RightMovement()
    {
        horizontalSpeed = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (horizontalSpeed * rightSpeed) * Time.deltaTime);
    }
    private void TouchRightMovement()
    {
        if (Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * 0.008f,
                    transform.position.y,
                    transform.position.z
                    );

            }

        }


    }
    private void Demarcation()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.78f, 2.85f), transform.position.y, transform.position.z);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawRotate : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    private float speed = 100f;
    void Update()
    {
        transform.Rotate(Vector3.forward *  (rotateSpeed * speed)* Time.deltaTime);
    }
}

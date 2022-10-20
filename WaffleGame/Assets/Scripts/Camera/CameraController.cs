using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject focus;
    [SerializeField] private Vector3 offset;

    // Update is called once per frame
    //rotataion x =36.056
    void Update()
    {
        if(focus) CameraLocation();
    }
    private void CameraLocation()
    {
        transform.position = Vector3.Lerp(transform.position, focus.transform.position + offset, Time.deltaTime * 2);
    }
}

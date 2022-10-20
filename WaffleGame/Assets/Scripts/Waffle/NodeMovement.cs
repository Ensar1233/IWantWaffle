using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{
    public Transform connectedObject;
    public float connectedObjectPositionZ = 1.5f;
    // Update is called once per frame

    void Update()
    {
        if (connectedObject != null)
        {
            
            SmoothTransition();

        }
      

    }
    private void SmoothTransition()
    {
            transform.position = new Vector3(
                Mathf.Lerp(transform.position.x, connectedObject.position.x, Time.deltaTime * 15f),
                transform.position.y,
                connectedObject.position.z + connectedObjectPositionZ
            );
        RemoveComponent();
        }
    private void RemoveComponent()
    {
        Destroy(transform.GetComponent<ExtansionController>());
    }
       


}

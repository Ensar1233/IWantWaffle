using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{

    [SerializeField] private GameObject midTable;

    [SerializeField] private GameObject customer;
    public bool isSpeedUp;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Waffle"))
        {
            
            isSpeedUp = true;
            SpeedUp();
            RemovedComponent(other.gameObject);

            Center();
        }
        
    }

    private void RemovedComponent(GameObject other)
    {
        other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                
    }
    private void SpeedUp()
    {
        GameObject.Find("Plate").GetComponent<Movement>().forwardSpeed = 8.5f;
    }
    private void Center()
    {
       float center = GameObject.Find("WallRight").transform.position.x + GameObject.Find("WallLeft").transform.position.x;

        Transform plate =  GameObject.Find("Plate").transform;

        plate.position = new Vector3(center, plate.position.y, plate.position.z);

        DisableController(plate);
    }
    private void DisableController(Transform plate)
    {
        plate.GetComponent<Movement>().touchMov = false;
        plate.GetComponent<Movement>().keyboardMov = false;
    }
}

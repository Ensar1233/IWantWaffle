using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extansions : MonoBehaviour
{
    private static int nameCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Extansion"))
        {

            Insertion(other.gameObject);

        }
        
    }
   
    private void Insertion(GameObject waffle)
    {
        nameCount++;


        GameObject[] cubes = GameObject.FindGameObjectsWithTag("Waffle");
        Vector3 newCube = new Vector3(cubes[cubes.Length - 1].transform.position.x, cubes[cubes.Length - 1].transform.position.y, cubes[cubes.Length - 1].transform.position.z + 0.8f);

        waffle.transform.position = newCube;

        waffle.gameObject.name = "Waffle" + nameCount;
        waffle.gameObject.AddComponent<NodeMovement>();
        waffle.gameObject.GetComponent<NodeMovement>().connectedObject = cubes[cubes.Length - 1].transform;


        AddWaffleComponenets(waffle,"Waffle");


    }
    private void AddWaffleComponenets(GameObject waffle,string tag)
    {
        //bu ikisi sonradan eklendi.

        waffle.gameObject.GetComponent<BoxCollider>().isTrigger = false;


        waffle.gameObject.AddComponent<Rigidbody>();
        waffle.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        waffle.gameObject.AddComponent<Extansions>();
        waffle.gameObject.AddComponent<BlobAnimation>();

        if(!waffle.CompareTag("FullPlate")) waffle.gameObject.AddComponent<ObstacleCollison>();

        waffle.gameObject.tag = tag;


    }
    
    
}

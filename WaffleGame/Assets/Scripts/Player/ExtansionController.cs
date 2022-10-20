using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtansionController : MonoBehaviour
{
    [SerializeField] bool playerIsTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsTrigger = true;
            FirstWaffleOnPlate(gameObject);
        }
        if(other.CompareTag("MidTable"))
        {
            playerIsTrigger = false;
        }
    }
    private Vector3 plate;
    private void Update()
    {
        /*Vector3 plate = GameObject.Find("Plate").transform.position;*/
        if (GameObject.Find("Plate") != null) plate = GameObject.Find("Plate").transform.position;

        if (playerIsTrigger)
        {
            transform.position = new Vector3(plate.x, plate.y+0.22f, plate.z);
        }
    }

    private void FirstWaffleOnPlate(GameObject firstWaffle)
    {


        firstWaffle.name = "Waffle";
        AddWaffleComponenets(gameObject, "Waffle");

    }
    private void AddWaffleComponenets(GameObject waffle, string tag)
    {

        waffle.gameObject.GetComponent<BoxCollider>().isTrigger = false;


        waffle.gameObject.AddComponent<Rigidbody>();
        waffle.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

        waffle.gameObject.AddComponent<Extansions>();
        waffle.gameObject.AddComponent<BlobAnimation>();
        

        if (!waffle.CompareTag("FullPlate")) waffle.gameObject.AddComponent<ObstacleCollison>();

        waffle.gameObject.tag = tag;


    }
}

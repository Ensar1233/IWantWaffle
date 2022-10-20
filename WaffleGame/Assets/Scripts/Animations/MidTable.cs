using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidTable : MonoBehaviour
{
    [SerializeField] ParticleSystem moneyConfiti;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Waffle"))
        {
            PlaceOnTable(other.gameObject);
            CreateMoneyConfit();

        }
        if (other.CompareTag("Player") || other.CompareTag("FullPlate"))
        {
            Destroy(other.gameObject,0.3f);
        }
    }
   private void PlaceOnTable(GameObject gameObject)
    {
        GetComponent<BoxCollider>().enabled = false;
        if (gameObject.GetComponent<NodeMovement>()) gameObject.GetComponent<NodeMovement>().connectedObject = null;
        gameObject.transform.position = this.gameObject.transform.position;
        gameObject.tag = "Ready";


    }

    private void CreateMoneyConfit()
    {
        Instantiate(moneyConfiti, gameObject.transform.position, moneyConfiti.transform.rotation);

    }
}

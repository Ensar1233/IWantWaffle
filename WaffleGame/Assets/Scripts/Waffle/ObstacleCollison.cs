using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollison : MonoBehaviour
{
   // çarpan objenin tag'i FullPlate ya da Player ise farklı bir işlen yapılacak.
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Obstacle") && transform.CompareTag("Waffle"))
        {
            AfterHittingTheObstacle(gameObject);
        }
        else if(other.gameObject.CompareTag("Obstacle") && (transform.CompareTag("FullPlate") || transform.CompareTag("Player")))
        {
            AfterHittingTheObstacle(GameObject.Find("Waffle"));
        }

    }
    private float previousPosition;
    private float currentPosition;

    private void Update()
    {
        currentPosition = transform.position.z;
        if (currentPosition == previousPosition)
        {
            StartCoroutine("AfterForceApplied");

        }

        previousPosition = currentPosition;

    }
    float currentForwardSpeed;
    IEnumerator AfterForceApplied()
        {
            yield return new WaitForSeconds(0.75f);
                if (GameObject.Find("Plate") != null)
                {
                    GameObject plate = GameObject.Find("Plate");
            if (plate.GetComponent<Movement>() != null) 
            {
                if (GameObject.Find("Finish").GetComponent<Finish>().isSpeedUp)
                {
                    plate.GetComponent<Movement>().forwardSpeed = 8.5f;
                }
                else
                {
                    plate.GetComponent<Movement>().forwardSpeed = 5.5f;
                }

            }
        }

    }

    private void AfterHittingTheObstacle(GameObject gameObject)
    {
        CapturedDestroyObject(gameObject);
        Destroy(gameObject);
        ApplyForce();
    }
    private void ApplyForce()
    {

        GameObject.Find("Plate").GetComponent<Rigidbody>().AddForce(-Vector3.forward * 7.5f, ForceMode.Impulse);
        GameObject.Find("Plate").GetComponent<Movement>().forwardSpeed = 0;
    }
   
    private void CapturedDestroyObject(GameObject waffle)
     {
         GameObject[] waffles = GameObject.FindGameObjectsWithTag("Waffle");
         for (int i = 0; i < waffles.Length; i++)
         {
            if(waffles[i].name == waffle.name)
            {
                Function(waffles, i);
            }
         }
     }
    //Bu fonksiyonda Destroy edilen objeden sonra ki objeler yakalanır ve gerekilen işlemler yapılır.
    private void Function(GameObject[] waffles,int capturedIndex)
    {

        for(int i = capturedIndex; i < waffles.Length; i++)
        {
            Destroy(waffles[i].GetComponent<Extansions>());
            Destroy(waffles[i].GetComponent<ObstacleCollison>());
            Destroy(waffles[i].GetComponent<NodeMovement>());
            Destroy(waffles[i].GetComponent<Rigidbody>());
            waffles[i].AddComponent<ExtansionController>();
            waffles[i].GetComponent<BoxCollider>().isTrigger = true;
            waffles[i].tag = "Extansion";
        }
    }

}

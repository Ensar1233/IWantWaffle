using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableController : MonoBehaviour
{
    public bool isWaffle = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ready"))
        {
            isWaffle = true;

        }
    }
}

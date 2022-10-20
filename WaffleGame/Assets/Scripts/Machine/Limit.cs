using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limit : MonoBehaviour
{
    public int value = -1;

    private void OnTriggerExit(Collider other)
    {
        if(other.name == "ÜstKol")
        {
            value *= -1;
        }
    }

}

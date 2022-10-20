using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateController : MonoBehaviour
{

    private int waffleCount;


    private void Update()
    {
        ChangeTag();

    }
    private void ChangeTag()
    {
        waffleCount = GameObject.FindGameObjectsWithTag("Waffle").Length;

        if (waffleCount <= 0)
        {
            gameObject.tag = "Player";
        }
        else
        {
            gameObject.tag = "FullPlate";
        }

    }

}

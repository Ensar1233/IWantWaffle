using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    
    public RuntimeAnimatorController[] controllers;
    [SerializeField] GameObject table;
    public void PlayRandomAnimation(int randNum)
    {
        GetComponent<Animator>().runtimeAnimatorController = controllers[randNum];
    }
    //Masa objesini bulma komutu verildiğinde sadece customer(2) deki masayı buluyor. Bu düzeltilecek.
    int count = 0;
    private void Update()
    {
        if (table.GetComponent<TableController>().isWaffle)
        {
            if (count < 2)
            {
                PlayRandomAnimation(Random.Range(0, 2));
                count++;
            }
            else
            {
                table.GetComponent<TableController>().isWaffle = false;
            }

        }

    }

}


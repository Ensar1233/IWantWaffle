using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobAnimation : MonoBehaviour
{



    [SerializeField] bool isTriggerFirinPerde = false;
    [SerializeField] bool isTriggerAnanasPerde = false;
    [SerializeField] bool isTriggerAhududuPerde = false;
    [SerializeField] bool isTriggerCilekPerde = false;
    [SerializeField] bool isTriggerKiviPerde = false;

    [SerializeField] bool isTriggerSurupMakine = false;
    [SerializeField] bool isTriggerRowByRowBlob = false;
    [SerializeField] bool isTriggerIceCreamMachine = false;


    int count = 0;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("FirinPerde") && !isTriggerFirinPerde && !isTriggerRowByRowBlob)
           {
            Blob();
            isTriggerFirinPerde = true;
            other.GetComponent<MoneyEffect>().ShowFloatingText("3$");
           }
        else if (other.gameObject.CompareTag("AnanasPerde") && !isTriggerAnanasPerde && !isTriggerRowByRowBlob)
        {
            Blob();
            isTriggerAnanasPerde = true;
            other.GetComponent<MoneyEffect>().ShowFloatingText("5$");
        }
        else if(other.gameObject.CompareTag("SurupMakine") && !isTriggerSurupMakine && !isTriggerRowByRowBlob)
        {
            Blob();
            isTriggerSurupMakine = true;
            other.GetComponent<MoneyEffect>().ShowFloatingText("2$");
        }
        else if (other.gameObject.CompareTag("AhududuPerde") && !isTriggerAhududuPerde && !isTriggerRowByRowBlob)
        {
            Blob();
            isTriggerAhududuPerde = true;
            other.GetComponent<MoneyEffect>().ShowFloatingText("5$");

        }
        else if(other.gameObject.CompareTag("CilekPerde") && !isTriggerCilekPerde && !isTriggerRowByRowBlob)
        {
            Blob();
            isTriggerCilekPerde = true;
            other.GetComponent<MoneyEffect>().ShowFloatingText("5$");
        }
        else if(other.gameObject.CompareTag("KiviPerde")&& !isTriggerKiviPerde && !isTriggerRowByRowBlob)
        {
            Blob();
            isTriggerKiviPerde = true;
            other.GetComponent<MoneyEffect>().ShowFloatingText("5$");
        }
        else if ((other.CompareTag("Waffle")||other.CompareTag("Player")||other.CompareTag("FullPlate")) && !isTriggerRowByRowBlob && count<2)
        {
            isTriggerRowByRowBlob = true;
            count++;
            StartCoroutine("RowByRowBlobAnimation");

        }
        else if (other.gameObject.CompareTag("IceCreamMachine") && !isTriggerIceCreamMachine)
        {
            isTriggerIceCreamMachine = true;
            other.GetComponent<MoneyEffect>().ShowFloatingText("3$");
        }
        
    }
    public void Blob()
    {
        GetComponent<Animator>().SetTrigger("extansion");
    }
    
    IEnumerator RowByRowBlobAnimation()
    {
        GameObject[] waffles = GameObject.FindGameObjectsWithTag("Waffle");
        
        int i = waffles.Length-1;
        while (i>=0)
        {
            waffles[i].GetComponent<Animator>().SetTrigger("extansion");
            
            yield return new WaitForSecondsRealtime(0.07f);
            i--;
        }
        if (i < 0)
        {
            isTriggerRowByRowBlob = false;
        }

    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelChange : MonoBehaviour
{
    private int modelcount;
    private int i;
    Renderer rend;

    private string childname;
    private int j;
    private int lenofsyrup;
    private int lenofkiwi;
    private int lenofstrawberry;
    private int lenofpineapple;
    private int lenofraspberry;
    private int lenoficecream;
    private int lenofsauce;
    private int bakedWaffle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CilekPerde"))
        {
            rendEnable("cilek", lenofstrawberry, true);
        }
        else if (other.CompareTag("AhududuPerde"))
        {
            rendEnable("ahududu", lenofraspberry, true);

        }
        else if (other.CompareTag("AnanasPerde"))
        {
            rendEnable("ananas", lenofpineapple, true);
        }
        else if (other.CompareTag("FirinPerde"))
        {
            rendEnable("BakedWaffle", bakedWaffle, true);
        }
        else if (other.CompareTag("SurupMakine"))
        {
            rendEnable("surup", lenofsyrup, true);

        }
        else if (other.CompareTag("IceCreamMachine"))
        {
            rendEnable("dondurma", lenoficecream, true);

        }
        else if (other.CompareTag("KiviPerde"))
        {
            rendEnable("kivi", lenofkiwi, true);

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        modelcount = 8;
        lenofsyrup = 11;
        lenofkiwi = 5;
        lenofstrawberry = 7;
        lenofpineapple = 4;
        lenofraspberry = 16;
        lenoficecream = 1;
        lenofsauce = 2;
        bakedWaffle = 1;

        rendEnable("surup", lenofsyrup, false);
        rendEnable("cilek", lenofstrawberry, false);
        rendEnable("kivi", lenofkiwi, false);
        rendEnable("ananas", lenofpineapple, false);
        rendEnable("ahududu", lenofraspberry, false);
        rendEnable("dondurma", lenoficecream, false);
        rendEnable("sos", lenofsauce, false);
        rendEnable("BakedWaffle", bakedWaffle, false);
    }

    
   public void rendEnable(string childstr, int len, bool isopened)
    {
        for (j = 1; j <= len; j++)
        {
            childname = childstr + j;
            rend = transform.Find(childname).gameObject.GetComponent<Renderer>();
            rend.enabled = isopened;
        }     
    }
}

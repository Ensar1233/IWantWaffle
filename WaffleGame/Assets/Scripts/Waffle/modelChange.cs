using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelChange : MonoBehaviour
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



    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        modelcount = 7;
        lenofsyrup = 9;
        lenofkiwi = 4;
        lenofstrawberry = 5;
        lenofpineapple = 4;
        lenofraspberry = 6;
        lenoficecream = 1;
        lenofsauce = 2;


        rendEnable("surup", lenofsyrup, false);
        rendEnable("cilek", lenofstrawberry, false);
        rendEnable("kivi", lenofkiwi, false);
        rendEnable("ananas", lenofpineapple, false);
        rendEnable("ahududu", lenofraspberry, false);
        rendEnable("dondurma", lenoficecream, false);
        rendEnable("sos", lenofsauce, false);
    }

    // Update is called once per frame
    void Update()
    {
        if (i < modelcount && Input.GetKeyDown("space"))
        {
            i++;
            addModel();
        }    
    }
    
    void addModel()
    {
        switch (i)
        {
            case 1:
                rendEnable("surup", lenofsyrup, true);
                break;
            case 2:
                rendEnable("cilek", lenofstrawberry, true);
                break;
            case 3:
                rendEnable("kivi", lenofkiwi, true);
                break;
            case 4:
                rendEnable("ananas", lenofpineapple, true);
                break;
            case 5:
                rendEnable("ahududu", lenofraspberry, true);
                break;
            case 6:
                rendEnable("dondurma", lenoficecream, true);
                break;
            case 7:
                rendEnable("sos", lenofsauce, true);
                break;
        }
    }

    void rendEnable(string childstr, int len, bool isopened)
    {
        for (j = 1; j <= len; j++)
        {
            childname = childstr + j;
            rend = transform.Find(childname).gameObject.GetComponent<Renderer>();
            rend.enabled = isopened;
        }     
    }
}

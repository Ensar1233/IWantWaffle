﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resulotion : MonoBehaviour
{
    
    void Start()
    {
        Screen.SetResolution(Screen.currentResolution.width / 2, Screen.currentResolution.height / 2,true);
    }

    void Update()
    {
        
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCtl : MonoBehaviour
{
    private Rigidbody rBody;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void startMove(){
        rBody = this.GetComponent<Rigidbody>();
        rBody.useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCtl : MonoBehaviour
{
    private Rigidbody rBody;
    int id;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void initialize(){
        GetComponent<Renderer>().material.color = Color.red;
        
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

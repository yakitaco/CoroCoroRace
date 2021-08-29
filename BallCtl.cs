using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCtl : MonoBehaviour
{
    private Rigidbody rBody;
    public string name;
    int id;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void initialize(string _name, Color _color){
        GetComponent<Renderer>().material.color = _color;
        name = _name;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sopn : MonoBehaviour
{

    public GameObject ball;
    Quaternion ballRotation = Quaternion.identity;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnCLick()
    {
       Instantiate(ball,new Vector3(20,10,-3), ballRotation);
    }
}

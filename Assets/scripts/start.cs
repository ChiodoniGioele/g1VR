using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Aggiungi questo namespace

public class start : MonoBehaviour
{
    
    void Start()
    {

    }

    
    void Update()
    {

    }

    
    public void onClick()
    {
    
        SceneManager.LoadScene("BasicScene"); 
    }
}

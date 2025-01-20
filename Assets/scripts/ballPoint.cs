using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballPoint : MonoBehaviour
{
    // Riferimento al ScoreManager
    private ScoreManager scoreManager;

    void Start()
    {
        // Trova l'istanza del ScoreManager
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Usa OnTriggerEnter invece di OnCollisionEnter
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "c1")
        {
            // Incrementa il punteggio di c1
            scoreManager.IncrementScoreC1();
            Debug.Log("Punteggio C1: " + scoreManager.GetScoreC1());
        }

        if (other.gameObject.name == "c2")
        {
            // Incrementa il punteggio di c2
            scoreManager.IncrementScoreC2();
            Debug.Log("Punteggio C2: " + scoreManager.GetScoreC2());
        }
    }
}

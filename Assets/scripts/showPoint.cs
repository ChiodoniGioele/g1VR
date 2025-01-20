using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class showPoint : MonoBehaviour
{

    public TextMeshProUGUI test;
    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {   
            test.text = scoreManager.GetScoreC1() + " : " + scoreManager.GetScoreC2();
    }
}

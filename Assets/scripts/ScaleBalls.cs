using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI; // Per lavorare con lo slider

public class ScaleBalls : MonoBehaviour
{

    public Slider scaleSlider;
    public float minScale = 0.5f; 
    public float maxScale = 3f;  


    public void OnSliderValueChanged()
    {

        GameObject[] balls = GameObject.FindGameObjectsWithTag("ball");
        float scale = Mathf.Lerp(minScale,maxScale,scaleSlider.value);
        foreach (GameObject ball in balls)
        {
            ball.transform.localScale = new Vector3(scale, scale, scale);
        }
    }
}

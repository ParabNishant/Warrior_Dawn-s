using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    public float value;
    public float maxValue;
    [Range(0, 1)]
    public float step;


    void Update()
    {
        value = Mathf.Lerp(value, maxValue, step * Time.deltaTime);    
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderValue : MonoBehaviour
{
    public Slider MySlider;
    public Text valSlider;

    void Update()
    {
        valSlider.text = MySlider.value.ToString("f2"); // float with two decimals 
    }
}

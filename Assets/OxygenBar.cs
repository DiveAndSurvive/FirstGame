﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenBar : MonoBehaviour {

    public float newScaleX;
    public float newScaleY;
    public static OxygenBar instance;

    // Use this for initialization
    void Start()
    {
        newScaleX = GetComponent<Transform>().localScale.x * 2 / 3;
        newScaleY = GetComponent<Transform>().localScale.y * 2 / 3;
        GetComponent<Transform>().localScale = new Vector3(newScaleX, newScaleY, GetComponent<Transform>().localScale.z);
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position = new Vector3(Movement.instance.GetComponent<Transform>().position.x - 4, Movement.instance.GetComponent<Transform>().position.y + 2.75F, Movement.instance.GetComponent<Transform>().position.z);
    }
}

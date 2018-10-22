using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenBar : MonoBehaviour {

    public static OxygenBar instance;
    public float newScaleX;
    public float newScaleY;

    // Use this for initialization
    void Start()
    {
        instance = this;
        newScaleX = GetComponent<Transform>().localScale.x * 2 / 3;
        newScaleY = GetComponent<Transform>().localScale.y * 2 / 3;
        GetComponent<Transform>().localScale = new Vector3(newScaleX, newScaleY, GetComponent<Transform>().localScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position = new Vector3(Movement.instance.GetComponent<Transform>().position.x - 4, Movement.instance.GetComponent<Transform>().position.y + 2.75F, Movement.instance.GetComponent<Transform>().position.z);
    }
}

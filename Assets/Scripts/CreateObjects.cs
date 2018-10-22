using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjects : MonoBehaviour
{
    public int objectsCount = 0;
    public GameObject whichObject;

    // Use this for initialization
    void Start()
    {
        Generate_Objects();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Generate_Objects()
    {
        var x_size = GetComponent<BoxCollider2D>().bounds.size.x;
        var y_size = GetComponent<BoxCollider2D>().bounds.size.y;
        var x_pos = GetComponent<BoxCollider2D>().transform.position.x;
        var y_pos = GetComponent<BoxCollider2D>().transform.position.y;
        for (int i = 0; i < objectsCount; ++i)
        {
            Vector3 pos = new Vector3((x_pos - x_size/2) + Random.value * x_size, (y_pos - y_size/2) + Random.value * y_size, -5);
            Instantiate(whichObject, pos, whichObject.transform.rotation);
        }
    }
}
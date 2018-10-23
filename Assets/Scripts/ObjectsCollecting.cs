using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsCollecting : MonoBehaviour
{

    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            bool wasCollected = Inventory.instance.Add(other.gameObject.GetComponent<Sprite>());
            if (wasCollected)
            {
                Destroy(other.gameObject);
            }
        }
    }
}
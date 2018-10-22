using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterHealth : MonoBehaviour {
    
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 12)
        {
            HealthBar.instance.GetComponent<Transform>().localScale = new Vector3(HealthBar.instance.GetComponent<Transform>().localScale.x - HealthBar.instance.GetComponent<Transform>().localScale.x/10, HealthBar.instance.GetComponent<Transform>().localScale.y, HealthBar.instance.GetComponent<Transform>().localScale.z);
        }
    }
}

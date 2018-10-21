using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterScript : MonoBehaviour {

    public string nazwa = "nie";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        nazwa = "tak";
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        nazwa = "nie";
    }

}

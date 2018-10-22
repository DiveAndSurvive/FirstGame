using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjects : MonoBehaviour {
    public int objectsCount = 0;
    public GameObject whichObject;
    public GameObject LU;
    public GameObject RU;
    public GameObject LD;
    public GameObject RD;
    public bool created = false;

    // Use this for initialization
    void Start () {
        Generate_Objects();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Generate_Objects()
    {
        for (int i = 0; i < objectsCount; ++i)
        {
            Vector3 pos = new Vector3(LU.transform.position.x + Random.value * (RU.transform.position.x - LU.transform.position.x), LU.transform.position.y + Random.value * (LD.transform.position.y - LU.transform.position.y), -10);
            Instantiate(whichObject, pos, whichObject.transform.rotation);
            created = true;
        }
        // GetComponent<BoxCollider2D>().bounds.size.x;
    }
}

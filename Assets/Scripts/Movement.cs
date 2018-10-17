using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float runSpeed;
    public float jumpSpeed;
    public float jumpVel;
    public float jumpDecaySpeed;
    public float gravity;

    public Rigidbody2D rig;

    Vector2 dir = new Vector2(0, 0);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jumpVel = jumpSpeed;
        }
        if (jumpVel > 0)
        {
            jumpVel -= jumpDecaySpeed * jumpSpeed * Time.deltaTime;
        }
        dir = new Vector2(Input.GetAxis("Horizontal") * runSpeed * Time.deltaTime, jumpVel - gravity * Time.deltaTime);
        rig.velocity = dir;
    }
}

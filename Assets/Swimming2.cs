using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swimming2 : MonoBehaviour {

    public bool isGrounded = false;
    private float startSpeed = 2;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && isGrounded)
        {
            float move = Input.GetAxis("Vertical");
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, move * Movement.instance.maxSpeed);
        }
        else if((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && isGrounded)
        {
            float move = Input.GetAxis("Vertical");
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, move * Movement.instance.maxSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 4)
        {
            isGrounded = true;
            Movement.instance.maxSpeed = 1;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(isGrounded && collision.gameObject.layer == 4)
        {
            isGrounded = false;
            Movement.instance.maxSpeed = startSpeed;
        }
    }

}

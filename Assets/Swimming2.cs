using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swimming2 : MonoBehaviour {

    public bool isGrounded = false;
    private float startSpeed = 2;
    private float startOxygenX;
    private float newPositionX;

    // Use this for initialization
    void Start () {
        //startOxygenX = OxygenBar.instance.GetComponent<Transform>().localScale.x;
        //startOxygenX = OxygenBar.instance.newScaleX;
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
        if (isGrounded && OxygenBar.instance.GetComponent<Transform>().localScale.x <= 0.666F && OxygenBar.instance.GetComponent<Transform>().localScale.x >= 0)
        {
            OxygenBar.instance.GetComponent<Transform>().localScale = new Vector3(OxygenBar.instance.GetComponent<Transform>().localScale.x - 0.0004F, OxygenBar.instance.GetComponent<Transform>().localScale.y, OxygenBar.instance.GetComponent<Transform>().localScale.z);
            //OxygenBar.instance.GetComponent<Transform>().position = new Vector3(Movement.instance.GetComponent<Transform>().position.x, OxygenBar.instance.GetComponent<Transform>().position.y, OxygenBar.instance.GetComponent<Transform>().position.z);
            //OxygenBar.instance.GetComponent<Transform>().position = new Vector3(OxygenBar.instance.GetComponent<Transform>().position.x - ((//OxygenBar.instance.GetComponent<BoxCollider2D>().bounds.size.x * 2 / 3) / 0.0012F), OxygenBar.instance.GetComponent<Transform>().position.y, OxygenBar.instance.GetComponent<Transform>().position.z);
        }
        else if(!isGrounded && OxygenBar.instance.GetComponent<Transform>().localScale.x < 0.666F)
        {
            OxygenBar.instance.GetComponent<Transform>().localScale = new Vector3(OxygenBar.instance.GetComponent<Transform>().localScale.x + 0.0004F, OxygenBar.instance.GetComponent<Transform>().localScale.y, OxygenBar.instance.GetComponent<Transform>().localScale.z);
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

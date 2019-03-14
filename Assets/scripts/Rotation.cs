using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

    public float speed;
    public Rigidbody2D rb2D;
    public GameObject donut;

    void Start() {

        rb2D = GetComponent<Rigidbody2D>();
        donut = GameObject.Find("donut");
        donut.transform.parent = rb2D.transform;
    }
    void FixedUpdate() {
    	float x =  Input.GetAxis("Mouse X"); 
		float y =  Input.GetAxis("Mouse Y"); 

    	Vector3 mousePosition = Input.mousePosition;
    	mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
    	Vector2 obj_position  = new Vector2(
    		mousePosition.x - rb2D.transform.position.x,
    		mousePosition.y - rb2D.transform.position.y);
    	rb2D.transform.up = obj_position;
    	//Debug.Log(Input.mousePosition);

       //rb2D.MoveRotation(rb2D.rotation + speed * Time.fixedDeltaTime);
    }
}


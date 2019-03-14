using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Script is work");	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	   private void OnTriggerEnter2D(Collider2D other)
    {
//            Debug.Log("entered");
    }
    private void OnTriggerStay2D(Collider2D other)
    {
    	// Debug.Log(other.gameObject.name.ToString());
     //	GameObject circle = GameObject.Find("Circle");
  //  	Debug.Log("TriggerStay is work");
//    	circle.GetComponent<SpriteRenderer>().color = other.gameObject.GetComponent<SpriteRenderer>().color;
    }


}

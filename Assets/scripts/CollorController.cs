using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class CollorController : MonoBehaviour {

		SpriteRenderer center_circle;
		SpriteRenderer circle_sprite;
		private string name_of_space;
		
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GameObject circle        = GameObject.Find("Circle");
		//circle_sprite = circle.GetComponent<SpriteRenderer>();
		SpriteRenderer circle_color = GetComponent<SpriteRenderer>();
 		//circle_color = center_circle.GetComponent<SpriteRenderer>().material.color;
 		//circle.GetComponent<SpriteRenderer>().color = circle_color.color;
 		//Debug.Log(circle_color.color);
		//circle_sprite.color = circle_color;
	}
}
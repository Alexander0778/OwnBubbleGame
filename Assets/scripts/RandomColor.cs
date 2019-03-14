using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour {
	public Color[] ColorBank;
	public bool sprite;
	float gameTimer = 0f;
	int check_index = 0; 
	float check_index_data = 0f;
	// Update is called once per frame
	void LateUpdate () {
		gameTimer += Time.deltaTime;
		if((int)gameTimer % 3 == 0 && check_index != 1) {
			check_index++;
			check_index_data = gameTimer + 1;
			int Num =  Random.Range(0,ColorBank.Length);
			if(sprite) {
				SpriteRenderer s = GetComponent<SpriteRenderer>();
				s.color = ColorBank[Num];
			}	
		}
		if(gameTimer > check_index_data) {
			check_index_data = 0f;
			check_index = 0;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {
	public Text game_timer_text;
	float gameTimer = 0f;

	// Update is called once per frame
	void Update () {
		gameTimer += Time.deltaTime;
	    float index = gameTimer - gameTimer % 1;
		game_timer_text.text = index.ToString();		
	}
}

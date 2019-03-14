using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPositionScript : MonoBehaviour {

	public float offset = 0;

	private	Color data_check_color;
	private	int   check_index      = 0;
	private	int   check_index_data = 0;
	// Use this for initialization

	void Start () {
	}

   private void OnTriggerEnter2D(Collider2D other)
    {
//            Debug.Log("entered");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
    	GameObject circle 	     = GameObject.Find("Circle");
    	GameObject center_circle = GameObject.Find("center_circle");
    	GameObject time_value    = GameObject.Find("time_value");

    		//	Debug.Log("TriggerStay is work");

    	circle.GetComponent<SpriteRenderer>().color = other.gameObject.GetComponent<SpriteRenderer>().color;
		int intValue;

		// attempt to parse the value using the TryParse functionality of the integer type
		
		int.TryParse(time_value.GetComponent<UnityEngine.UI.Text>().text, out intValue);

    	if (intValue % 3 == 0 && check_index == 0 && data_check_color != null ) {
	    	if (data_check_color == other.gameObject.GetComponent<SpriteRenderer>().color)
	    	{
	   			this.CloudAnimation(0);
	    	}
	    	else
	    	{
	    		this.CloudAnimation(1);
	    	}
	    	check_index++;    	
	    	check_index_data = intValue;	
    	}
    	else {
    		data_check_color = center_circle.GetComponent<SpriteRenderer>().color;
    		 if(check_index_data + 1 < intValue	) {
    		 	check_index	= 0;
    		 	check_index_data = 0;
    		 }
    	}

    }

	// Update is called once per frame
	void Update () {
       if (Input.GetMouseButtonDown(0))
            {
                int index = 0;

                Debug.Log("Pressed primary button.");   

                this.CloudAnimation(index);
            }
            
        if (Input.GetMouseButtonDown(1))
             {
                Debug.Log("Pressed secondary button.");

                int index = 1;

                this.CloudAnimation(index);
             }
         
    }
		
	
	void CloudAnimation(int index)
	{

		if(index == 0)
		{
			float x = transform.position.x/3;
			float y = transform.position.y/3;
			transform.position = new Vector3 (transform.position.x - x, transform.position.y - y, transform.position.z);	
		}
		else
		{
			float x = transform.position.x/2;
			float y = transform.position.y/2;
			transform.position = new Vector3 (transform.position.x + x, transform.position.y + y, transform.position.z);	
		}
 		
	}
}

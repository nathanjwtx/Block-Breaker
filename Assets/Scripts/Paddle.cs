using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	
	// Update is called once per frame
	void Update ()
	{
		var paddlePos = new Vector3(0.5f, transform.position.y, 0); 
		// relateive x position of mouse on screen in the 16 world units set for the game width
		var mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
//		print(mousePosInBlocks);
		paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);
		transform.position = paddlePos;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Ball : MonoBehaviour
{

	private Paddle _paddle;
	private Vector3 _paddleToBallVector;
	private bool _started;
	
	// Use this for initialization
	void Start ()
	{
		_paddle = FindObjectOfType<Paddle>();
		_paddleToBallVector = transform.position - _paddle.transform.position;
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (_started)
		{
			var boing = GetComponent<AudioSource>();
			boing.Play();	
		}
	}

	// Update is called once per frame
	void Update ()
	{
		if (_started) return;
		transform.position = _paddle.transform.position + _paddleToBallVector;

		if (Input.GetMouseButtonDown(0))
		{
			_started = true;
			GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f); 
		}
	}
}

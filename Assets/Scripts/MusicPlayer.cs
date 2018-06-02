using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
	private static MusicPlayer _instance;
	// Use this for initialization

	private void Awake()
	{
		if (_instance == null)
		{
			DontDestroyOnLoad(gameObject);
			_instance = this;
			Debug.Log("Instance created");
		}
		else
		{
			Destroy(gameObject);
			Debug.Log("Destroyed");
		}
	}
	
	// Update is called once per frame
//	void Update () {
//		
//	}
}

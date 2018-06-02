using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brick : MonoBehaviour
{
	public LevelManager LevelManager;
	public Sprite[] HitSprites;

	private int _timesHits;
	
	// Use this for initialization
	void Start ()
	{
		_timesHits = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	private void OnCollisionEnter2D(Collision2D collision2D)
	{
		var breakable = CompareTag("Breakable");
		if (breakable)
		{
			HandleHits();
		}
	}

	void HandleHits()
	{
		var maxHits = HitSprites.Length + 1;
		_timesHits += 1;
		
		if (_timesHits >= maxHits)
		{
			Destroy(gameObject);
		}
		else
		{
			LoadSprites();
		}		
	}
	
	// TODO	remove this method once we can actually win!
	void SimulateWin()
	{
		LevelManager = FindObjectOfType<LevelManager>();
		LevelManager.LoadNextLevel();
	}

	void LoadSprites()
	{
		var spriteIndex = _timesHits - 1;
		if (HitSprites[spriteIndex])
		{
			GetComponent<SpriteRenderer>().sprite = HitSprites[spriteIndex];	
		}
	}
}

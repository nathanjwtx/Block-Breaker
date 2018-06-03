using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brick : MonoBehaviour
{
	public static int BrickCount;
	
	public LevelManager LevelManager;
	public Sprite[] HitSprites;

	private int _timesHits;
	private bool _breakable;
	
	// Use this for initialization
	void Start ()
	{
		_breakable = CompareTag("Breakable");
		if (_breakable)
		{
			BrickCount += 1;
		}
		_timesHits = 0;
		LevelManager = FindObjectOfType<LevelManager>();
	}

	private void OnCollisionEnter2D(Collision2D collision2D)
	{
		if (_breakable)
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
			BrickCount -= 1;
			LevelManager.BrickDestroyed();
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

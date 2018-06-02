using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCollider : MonoBehaviour
{

    private LevelManager _levelManager;
    
    private void OnTriggerEnter2D(Collider2D cricketball)
    {
        _levelManager = FindObjectOfType<LevelManager>();
        _levelManager.LoadLevel("Win");
    }

//    private void OnCollisionEnter2D(Collision2D collision)
//    {
//        Debug.Log("Collison");
//    }
}

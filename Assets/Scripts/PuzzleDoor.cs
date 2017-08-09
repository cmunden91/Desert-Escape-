using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleDoor : MonoBehaviour {
    public AudioClip puzzlesolve;
    
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Activated");
        if (obj.Length == 5)
        {
            Destroy(gameObject);
            GameObject ter = GameObject.FindGameObjectWithTag("Terrian");
            ter.layer = 0;
            AudioSource.PlayClipAtPoint(puzzlesolve, transform.position);

        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PuzzleOneMain : MonoBehaviour {




    // Use this for initialization
    void Start () {
        GameObject puzzle1 = GameObject.Find("Puzzle1");
        GameObject[] puzzlepieces = new GameObject[puzzle1.transform.childCount];
        for(int i = 0; i < puzzle1.transform.childCount; i++)
        {
            puzzlepieces[i] = transform.GetChild(i).gameObject;
        }


        for(int i = 0; i < 5; i++)
        {
            int x = Random.Range(0, puzzle1.transform.childCount);
            if (puzzlepieces[x].tag == "Active")
            {
                i--;
            }
            else
            {
                puzzlepieces[x].tag = "Active";
            }
            
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

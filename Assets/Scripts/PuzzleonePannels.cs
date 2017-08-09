using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleonePannels : MonoBehaviour {
    public void selected()
    {
     
    }

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
		
		MeshRenderer my_renderer = GetComponent<MeshRenderer>();
		if (gameObject.tag == "Active")
		{
            
            gameObject.transform.position += new Vector3((float)-.03, 0, 0);
			gameObject.tag = "Activated";
			
			
		}


	}

	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonSelection : MonoBehaviour {




    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            
            RaycastHit hit = new RaycastHit();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Active"))
                {
                    Material active = Resources.Load("Main/Materials/puzzle1active.mat", typeof(Material)) as Material;
                    hit.collider.gameObject.GetComponent<MeshRenderer>().material = active;
                    Debug.Log("Test");
                }

            }
        }
    }
}

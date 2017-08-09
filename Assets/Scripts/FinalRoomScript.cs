using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalRoomScript : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
        
    }

    IEnumerator Destroyself()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
    void OnCollisionEnter(Collision collision) {
        StartCoroutine(Destroyself());
        GameObject[] finalroomblocks = GameObject.FindGameObjectsWithTag("Final Room");
        for(int i = 0; i < finalroomblocks.Length; i++)
        {
            finalroomblocks[i].layer = 8;
        }


    }

    // Update is called once per frame
    void Update () {
    
	}
}

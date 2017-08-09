using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionScript : MonoBehaviour {
    
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
        char roomno = gameObject.tag[5];
        if (GameObject.FindGameObjectWithTag("Wall " + roomno) != null)
        {
            Destroy(GameObject.FindGameObjectWithTag("Wall " + roomno));
        }
        GameObject[] nextroom;
        nextroom = GameObject.FindGameObjectsWithTag(gameObject.tag);

        for (int i = 0; i < nextroom.Length; i++)
        {
            nextroom[i].layer = 8;
        }
        
        
    }

    // Update is called once per frame
    void Update () {
    
	}
}

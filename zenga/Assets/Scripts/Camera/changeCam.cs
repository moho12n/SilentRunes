using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCam : MonoBehaviour {


    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
         {  
               collision.gameObject.transform.Rotate(0,-90,0);
               }
        Destroy(this.gameObject);
    }

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

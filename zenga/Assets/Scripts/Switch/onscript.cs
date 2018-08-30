using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onscript : MonoBehaviour {
     public GameObject switcher;
	 public void OnTriggerEnter(Collider col)
	 {
        if(col.gameObject.CompareTag("Player")){switcher.gameObject.SetActive(true);}

	 }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchlvl3 : MonoBehaviour {
    public GameObject rotate5,rotate6,rotate7,block;
	// Use this for initialization
	void OnTriggerEnter(Collider col)
	    {
		if(col.gameObject.CompareTag("Player"))
			{
               rotate5.SetActive(true);
			   rotate6.SetActive(true);
			   rotate7.SetActive(true);
			   block.SetActive(false);
			}
		}
}

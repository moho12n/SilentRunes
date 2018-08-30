using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingfloor : MonoBehaviour {
    float start = 0;
	void OnCollisionEnter(Collision col)
	{
        if(col.gameObject.CompareTag("Player")){start = Time.timeSinceLevelLoad;}

	}
	// Update is called once per frame
	void Update() {
		if(Time.timeSinceLevelLoad - start > 0.5 && start != 0){this.gameObject.GetComponent<Rigidbody>().isKinematic = false;}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tuto : MonoBehaviour {
   bool jump,Run,spawn,walk;
	void Update () {
		if(Input.GetAxis("Horizontal") > 0.5f && !walk){GetComponent<Text>().text = "Now press Left Shift to Run ";walk = true;}
		if(Input.GetAxis("Horizontal") > 0.1f && walk && !Run && Input.GetKeyDown(KeyCode.LeftShift)){GetComponent<Text>().text = "Now press Space to jump ";Run = true;}
	    if(Input.GetKeyDown(KeyCode.Space) && !jump && walk && Run){GetComponent<Text>().text = "Press E to spawn a cube to jump into it ";jump = true;}
	    if(Input.GetKeyDown(KeyCode.E) && jump && walk && Run){spawn = true;}
		if(jump && walk && Run && spawn)Destroy(this.gameObject);
	}
}

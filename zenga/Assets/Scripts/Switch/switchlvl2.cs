using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchlvl2 : MonoBehaviour {
      public GameObject pont,switcher,trigger;
	  float start = 0;
	  float hight = 0;
	  bool isActive = false;

    void OnTriggerEnter(Collider col)
	{
           if(col.gameObject.CompareTag("Player"))
		   {
               switcher.gameObject.transform.Rotate(45,0,0);
			   trigger.gameObject.SetActive(true);
               start = Time.timeSinceLevelLoad;
			   isActive = true;
		   }

	}
	// Use this for initialization
	// Update is called once per frame
	void Update () {
		if(isActive && hight < 7){hight += 0.1f;pont.transform.position+=new Vector3(0f,0.1f,0f);}
		if(hight == 7){start = Time.timeSinceLevelLoad;}
		if(hight == 0 &&  start != 0) {Destroy(pont.gameObject);}
		if( hight > 0 && start != 0 && Time.timeSinceLevelLoad - start > 20){   pont.gameObject.transform.position -= new Vector3(0f,0.1f,0f);}
	}
}

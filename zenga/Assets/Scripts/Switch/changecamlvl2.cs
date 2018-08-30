using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecamlvl2 : MonoBehaviour {

 public GameObject cam1,cam2;
	 void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
         {  
			 cam1.gameObject.SetActive(false);
			   cam2.gameObject.SetActive(true);
               collision.gameObject.transform.Rotate(0,-90,0);
               }
        Destroy(this.gameObject);
    }
}

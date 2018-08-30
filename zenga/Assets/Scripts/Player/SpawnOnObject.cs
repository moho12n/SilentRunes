using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnObject : MonoBehaviour {
 public  GameObject obj;
 	 public Transform objPos;
  	GameObject LastObj;
 	public int data=0 ;
 	public float Timer;
 	public float Delay;
	public int round;
	public float o=5;
	public int x=5;
	// Use this for initialization
	void Start () {
        obj.gameObject.transform.localScale = new Vector3(1f,1f,1f);
	}
	
	// Update is called once per frame
	void Update () {
		SpawnCube();
		ResetData();
			}
	void  ResetData()
	{
		
	
	 if(data==round)
	 {
		 if(Timer<Delay)
		 {
			 Timer+=Time.deltaTime;
			 o-=Time.deltaTime;
		 }
		 else
		 {
			 o=5;
			 Timer=0;
			 data=0;
			 x=5;
		 }
	 }		

	}
	void SpawnCube()
  {
	  	if(data<round)
		  {
			   if(Input.GetKeyDown(KeyCode.E))
	   {
		   	data=data+1;
			   x=x-1;
		   	if(LastObj!=null)
			   {
				   Destroy(LastObj);
				   LastObj=null;
			   }

				if(LastObj==null)
				LastObj=Instantiate(obj,objPos.position,objPos.rotation);
	   }
		  }
  }

  /* IEnumerator waitNextSpown()
   {
	   yield return new WaitForSeconds(x);
	   data
   }*/
}

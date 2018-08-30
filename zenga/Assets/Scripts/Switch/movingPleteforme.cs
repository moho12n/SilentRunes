using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movingPleteforme : MonoBehaviour {
	public Transform obj;
    bool direction;
	float height;
	float speed=0.5f;
	// Use this for initialization
	void Start () {
      direction = true;
	  height = 0f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(direction)
		{
		height += 0.1f;
		transform.position += new Vector3(0f,0.1f,0f);
		if(height > obj.transform.position.y){direction = false;}
		}
		else 
		{
        height -= 0.1f;
		transform.position -= new Vector3(0f,0.1f,0f);
		if(height < 0f){direction = true;}
		}
		
	}


	void OnCollisionEnter(Collision Collision)
	{ 
		if(Collision.gameObject.CompareTag("Player")){SceneManager.LoadScene(0);}
	}	
	

	
}

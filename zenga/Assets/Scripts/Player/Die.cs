﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour {

   void OnCollisionEnter(Collision collision)
   {
	   if(collision.gameObject.CompareTag("Player")){SceneManager.LoadScene(0);}
   }


}

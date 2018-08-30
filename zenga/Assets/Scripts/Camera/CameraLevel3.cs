using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraLevel3 : MonoBehaviour {
	
	 CinemachineTrackedDolly doll;
	 public CinemachineVirtualCamera virt;
	// Use this for initialization
	void Start () {
		doll = virt.GetComponent<CinemachineTrackedDolly>();
		doll.m_AutoDolly.m_PositionOffset = 1f;
	}
	
	// Update is called once per frame
	void Update () {
	}
}

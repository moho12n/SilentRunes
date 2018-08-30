using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixRotate : MonoBehaviour {

    public Transform player;
    private Vector3 lastTrans;

    void Start()
    {
        lastTrans = player.position;
    }

    void Update()
    {
        transform.position += new Vector3 ( player.position.x - lastTrans.x , player.position.y - lastTrans.y, player.position.z - lastTrans.z );
        lastTrans = player.position;
    }
}

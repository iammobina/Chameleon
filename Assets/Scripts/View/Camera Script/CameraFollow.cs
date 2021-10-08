using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    private Transform player;

	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	void Update () {
		if(transform.position.y < player.position.y)
        {
            Vector3 camera = transform.position;

            camera.y = player.position.y;

            transform.position = camera;
        }
	}
}

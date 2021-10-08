using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Obstacle" || target.tag == "StartPoint")
        {
            Destroy(target.gameObject);
        }
    }
}

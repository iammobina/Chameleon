using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   
    public float speed = 90f;

    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}

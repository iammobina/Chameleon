using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public int damage = 1;
    public bool isEnemyShot = false;
    void Start()
    {
        Destroy(gameObject, 10);

    }


}

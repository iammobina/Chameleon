using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BulletMovementPlayer : MonoBehaviour
{
    public Vector2 speed = new Vector2(50, 50);
    public Vector2 direction = new Vector2(-1, 0);

    // Update is called once per frame
    void Update()
    {
            Vector3 movemnt = new Vector3(speed.x * direction.x * Time.deltaTime , speed.y * direction.y * Time.deltaTime, 0);
           // transform.DOMove(new Vector3(speed.x * direction.x * Time.deltaTime, speed.y * direction.y * Time.deltaTime, 0) , 1).SetLoops(-1, LoopType.Yoyo);
           
            transform.Translate(movemnt);
    }
}

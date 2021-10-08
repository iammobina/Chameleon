using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public Vector2 speed = new Vector2(50, 50);
    public Vector2 direction = new Vector2(-1, 0);
    public AudioClip EnemyAudio;

    // Update is called once per frame
    void Update()
    {
        Vector3 movemnt = new Vector3(speed.x * direction.x, speed.y * direction.y, 0);
        movemnt *= Time.deltaTime;
        transform.Translate(movemnt);
        AudioSource.PlayClipAtPoint(EnemyAudio, transform.position);
    }
}

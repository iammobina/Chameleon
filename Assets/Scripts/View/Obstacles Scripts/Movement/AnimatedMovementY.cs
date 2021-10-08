using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AnimatedMovementY : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public float duration = 5;
    void Start()
    {
        transform.DOMove(new Vector3(0, transform.position.y, 0), 0.5f).SetLoops(-1, LoopType.Restart);
    }

    // Update is called once per frame
    void Update()
    {


    }
}

using UnityEngine;
using DG.Tweening;

public class AnimatedMovement : MonoBehaviour
{
    [SerializeField]
    public float duration = 5;
    void Start()
    {
        transform.DOMove(new Vector3(0, transform.position.x, 0), duration).SetLoops(-1, LoopType.Yoyo);
    }

    void Update()
    {


    }
}

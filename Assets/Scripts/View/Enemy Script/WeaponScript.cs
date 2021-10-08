using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public Transform shotPrefabe;
    public float shootingRate = 0.25f;
    private float shootCoolDown;


    void Start()
    {
        shootCoolDown = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(shootCoolDown > 0)
        {
            shootCoolDown -= Time.deltaTime;
        }
    }
    public void Attack(bool isEnemy)
    {
        if (CanAttack)
        {
            shootCoolDown = shootingRate;
            var shotTransform = Instantiate(shotPrefabe) as Transform;
            shotTransform.position = transform.position;
            Shooting shot = shotTransform.gameObject.GetComponent<Shooting>();


            if (shot != null)
            {
                shot.isEnemyShot = isEnemy;
            }


        }
    }
    public bool CanAttack
    {
        get
        {
            return shootCoolDown <= 0f;
        }
    }
}

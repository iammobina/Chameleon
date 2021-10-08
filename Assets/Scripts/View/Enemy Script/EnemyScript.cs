using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private WeaponScript weapon;
    private GameObject playerObject;
    void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("enemy");


    }


    private void Awake()
    {
        weapon = GetComponent<WeaponScript>();
    }

    // Update is called once per frame
    void Update()
    {

            if (weapon != null && weapon.CanAttack)
            {
                weapon.Attack(true);

            }
        
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "enemy")
        {
            Destroy(gameObject);
        }
        if (target.tag == "greenbullet")
        {
            Debug.Log("khord be greenbullet");
            //playerObject.SetActive(false);
            Destroy(gameObject);
        }
        if (this.tag == "yellowsnake")
        {
            if (target.tag == "greenbullet")
            {
                Debug.Log("khord be greenbullet");
                //playerObject.SetActive(false);
                Destroy(gameObject);
            }
        }

        if (this.tag == "pinksnake")
        {
            if (target.tag == "greenbullet")
            {
                Debug.Log("khord be greenbullet");
                //playerObject.SetActive(false);
                Destroy(gameObject);
            }
        }

        if (this.tag == "monkeyshot")
        {
            if (target.tag == "greenbullet")
            {
                Debug.Log("khord be greenbullet");
                //playerObject.SetActive(false);
                Destroy(gameObject);
            }
        }

    }

}


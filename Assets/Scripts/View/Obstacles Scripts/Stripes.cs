using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stripes : MonoBehaviour {

    public float speed;
    private Transform[] stripes;

	void Start () {
        stripes = new Transform[8];
        for(int i = 0; i < 8; i++)
        {
            stripes[i] = transform.GetChild(i);
        }

	}

	void Update () {
        if((speed / Mathf.Abs(speed)) == 1)
        {
            for(int i = 0; i < 8; i++)
            {
                stripes[i].Translate(new Vector3(speed * Time.deltaTime, 0, 0));

                if (stripes[i].position.x >= 4f)
                {
                    float rest = stripes[i].position.x - 4f;
                    stripes[i].position = new Vector3(-10.27f + rest, transform.position.y, 0);
                }

            }
        }
        else if ((speed / Mathf.Abs(speed)) == -1)
        {
            for(int i = 0; i < 8; i++)
            {
                stripes[i].Translate(new Vector3(speed * Time.deltaTime, 0, 0));

                if (stripes[i].position.x <= -4)
                {
                    float rest = stripes[i].position.x + 4f;
                    stripes[i].position = new Vector3(10.27f + rest, transform.position.y, 0);
                }

            }
        }
	}
}

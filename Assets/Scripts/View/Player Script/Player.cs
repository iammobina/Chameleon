using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using RTLTMPro;
using DG.Tweening;

public class Player : MonoBehaviour {
    

    [SerializeField]
    private Rigidbody2D myBody;
    public RTLTextMeshPro textLive;
    private SaveManager saveManager;
    public AudioClip starClip, colorChangeClip, jumpClip, deathCilp;

    public GameObject Playerbullet;

    private string[] colorsName;
    public string activeColor;
    public float jump = 7f;




    void Awake()
    {
        colorsName = new string[4];
        colorsName[0] = "yellow";
        colorsName[1] = "pink";
        colorsName[2] = "cyan";
        colorsName[3] = "purple";

        activeColor = "";
    }

    void Start()
    {
   
        saveManager = SaveManager.insatanse;
        int randomColor = Random.Range(0, colorsName.Length);
        activeColor = colorsName[randomColor];
        textLive.text = saveManager.GetTotall() + "";

    }

    void Update () {

        if (transform.position.x != 50)
        {

            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.W))
            {
                myBody.velocity = Vector2.up * jump;
                AudioSource.PlayClipAtPoint(jumpClip, transform.position);
            }

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GameObject playerBullet = GameObject.Instantiate<GameObject>(Playerbullet);
            playerBullet.transform.position = this.transform.position;
        }
    }

    public void GameOver()
    {
        StartCoroutine(Death());
       
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "bullet")
        {
            Debug.Log("bullet in palyer.cs");
            saveManager.setTotall();
            textLive.text = saveManager.GetTotall() + "";
            
            if (saveManager.GetTotall() <= 0)
            {
                //playerObject.SetActive(false);
                GameOver();
            }
        }

        if (target.tag == "star")
        {
            ScoreController.instance.AddScore();
            //in the GDD i explained if the player score is bigger than 100 it gives life bounes 
            //for following that i should change this to 100
            if (ScoreController.instance.GetScore() == 1)
            {
                SaveManager.insatanse.donateTotall();
                textLive.text = saveManager.GetTotall() + "";
            }
            Destroy(target.gameObject);
            AudioSource.PlayClipAtPoint(starClip, transform.position);
        }

        if(target.tag == "color")
        {
            int randomColor = Random.Range(0, colorsName.Length);
            activeColor = colorsName[randomColor];
            Destroy(target.gameObject);
            AudioSource.PlayClipAtPoint(colorChangeClip, transform.position);
        }

        if (target.tag == "enemy")
        {
            target.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }

    }
    IEnumerator Death()
    {
        AudioSource.PlayClipAtPoint(deathCilp, transform.position);
        transform.position = new Vector2(50, transform.position.y);
        File.instance.SaveIntoJson();
        yield return new WaitForSeconds(.3f);
        SceneFader.instance.FadeIn("DeathMenu");
    }

}

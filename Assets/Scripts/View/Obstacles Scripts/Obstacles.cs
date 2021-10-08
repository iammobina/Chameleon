using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RTLTMPro;

public class Obstacles : MonoBehaviour
{ 
    private Player player;
    private bool AlreadyDone;
    private SaveManager saveManager;
    public RTLTextMeshPro textLive;

    void Start()
    {
        saveManager = SaveManager.insatanse;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (player.activeColor != this.tag)
        {
                Debug.Log("player.activeColor " + player.activeColor);
                Debug.Log("this tag " + this.tag);
                if (!AlreadyDone)
                {
                    AlreadyDone = true;
                    saveManager.setTotall();
                    textLive.text = saveManager.GetTotall() + "";
                    //    player.GameOver();
                }
                if (saveManager.GetTotall() <= 0)
                {
                    player.GameOver();
                }

            }

            
        }

}

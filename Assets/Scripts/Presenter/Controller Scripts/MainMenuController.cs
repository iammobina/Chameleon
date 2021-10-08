using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

    [SerializeField]
    private Button musicBtn;
    [SerializeField]
    private Sprite[] musicIcons;

    void Update()
    {
        MusicCheck();
    }

    void MusicCheck()
    {
        if (PlayerPrefs.GetInt("Music") == 0)
        {
            MusicController.insntace.PlayMusic(false);
            musicBtn.image.sprite = musicIcons[0];
        }
        else
        {
            MusicController.insntace.PlayMusic(true);
            musicBtn.image.sprite = musicIcons[1];
        }
    }

    public void PlayGame()
    {
        SceneFader.instance.FadeIn("Gameplay");
    }

    public void Music()
    {

        if(PlayerPrefs.GetInt("Music") == 0)
        {
            PlayerPrefs.SetInt("Music", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Music", 0);
        }
    }

}

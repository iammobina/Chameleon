using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    private Player playerColor;
    private SpriteRenderer playerSR;

    private Color[] colors;

    public GameObject pausePanel;

	void Start () {
        colors = new Color[4];
        colors[0] = new Color(245 / 255f, 222 / 255f, 22 / 255f, 1f); //yellow
        colors[1] = new Color(244 / 255f, 5 / 255f, 132 / 255f, 1f); //pink
        colors[2] = new Color(48 / 255f, 228 / 255f, 242 / 255f, 1f); //cyan
        colors[3] = new Color(143 / 255f, 16 / 255f, 253 / 255f, 1f); //purple

        playerColor = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerSR = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
    }
	
	void Update () {
        if (playerColor.activeColor == "yellow")
            playerSR.color = colors[0];

        if (playerColor.activeColor == "pink")
            playerSR.color = colors[1];

        if (playerColor.activeColor == "cyan")
            playerSR.color = colors[2];

        if (playerColor.activeColor == "purple")
            playerSR.color = colors[3];
    }

    public void Home()
    {
        Time.timeScale = 1;
        SceneFader.instance.FadeIn("MainMenu");
    }

    public void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
}

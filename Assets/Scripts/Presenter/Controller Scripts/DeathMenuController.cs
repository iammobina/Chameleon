using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenuController : MonoBehaviour {

	public void HomeButton()
    {
        ScoreController.instance.ResetScore();
        SaveManager.insatanse.RestTotall();
        SceneFader.instance.FadeIn("MainMenu");
    }

    public void RestartButton()
    {
        ScoreController.instance.ResetScore();
        SaveManager.insatanse.RestTotall();
        SceneFader.instance.FadeIn("Gameplay");
    }

}

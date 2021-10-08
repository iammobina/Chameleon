using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class File : MonoBehaviour
{
    [SerializeField]
    public FileModel storedData = new FileModel();
    public static File instance;
    public static SaveManager insatanse;
    public SaveConfig saveConfig;

    void Awake()
    {
        MakeSingleton();
    }

    void MakeSingleton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void SaveIntoJson()
    {
        storedData.score = ScoreController.instance.GetScore() + "";
        storedData.highscore = ScoreController.instance.GetHighScore() + "";
        storedData.spendtime = Time.time;
        storedData.is_donated = SaveManager.insatanse.is_donate();
        string ftext = JsonUtility.ToJson(storedData);
        PlayerPrefs.SetString("StoredData", ftext);
        System.IO.File.AppendAllText(saveConfig.path, ftext + "\n");

    }


}

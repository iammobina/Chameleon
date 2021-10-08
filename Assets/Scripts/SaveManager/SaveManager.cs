using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager :MonoBehaviour
{
    public static SaveManager insatanse;
    public static File file;
    public SaveConfig saveConfig;
    public static bool is_donated;

    private void Awake()
    {
        insatanse = this;
    }
    void Start()
    {
        GetTotall();
     
    }


    public int GetTotall()
    {
        return saveConfig.totall = PlayerPrefs.GetInt(saveConfig._TOTALL, saveConfig.totall);
    }

    public void setTotall()
    {
        saveConfig.totall = GetTotall();
        saveConfig.totall--;

        PlayerPrefs.SetInt(saveConfig._TOTALL, saveConfig.totall);

        Debug.Log("setTotall" + saveConfig.totall);
    }

    public void donateTotall()
    {
        saveConfig.totall = GetTotall()+1;
        is_donated = true;
        PlayerPrefs.SetInt(saveConfig._TOTALL, saveConfig.totall);

        Debug.Log("donateTotall" + saveConfig.totall);
    }


    public void RestTotall()
    {
        saveConfig.totall = GetTotall();
        saveConfig.totall = 3;

        PlayerPrefs.SetInt(saveConfig._TOTALL, saveConfig.totall);

        Debug.Log("RestTotall" + saveConfig.totall);
    }

    public bool is_donate() { 
        if(is_donated)
        {
            return true;
        }
        return false;
    }

}

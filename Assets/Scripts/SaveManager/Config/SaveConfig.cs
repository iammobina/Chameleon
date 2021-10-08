using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(menuName = "SaveManager/SaveConfig") ]
public class SaveConfig : ScriptableObject
{
    public string _TOTALL = "totall";
    public int totall = 3;
    public  string path = @"C:\Users\AVAJANG\Desktop\game_final_project\Assets\Resources\StoredData.txt";
}
